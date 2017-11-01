using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Quest_Enemy_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class DataManager
    {
        #region Fields

        const string InputFolder = "InputData/";
        readonly List<Race> races;
        readonly List<GameClass> gameClasses;
        readonly List<Weapon> weapons;
        readonly List<Glyph> glyphs;
        readonly List<WeaponBlueprint> weaponBlueprints;
        readonly List<WeaponEnchant> weaponEnchants;
        readonly List<WeaponUpgrade> weaponUpgrades;
        List<Armor> armors;
        List<ArmorBlueprint> armorBlueprints;
        List<ArmorEnchant> armorEnchants;

        // Create the RNG
        readonly Random random;

        // Set up branching thresholds
        const double Common = 0.6;

        const double Uncommon = 0.85;
        const double Rare = 0.93;

        #endregion

        #region Constructors

        public DataManager()
        {
            //glyphs = new List<Glyph> { new Glyph("Impact Snap", MagicianType.IMP, 5, 4, "blablalbalba") };

            //XmlSerializer createSerializer = new XmlSerializer(typeof(List<Glyph>));
            //Directory.CreateDirectory(InputFolder);
            //FileStream createStreamer = new FileStream($"{InputFolder}{nameof(Glyph)}List.xml", FileMode.Create);
            //using (createStreamer)
            //{
            //    createSerializer.Serialize(createStreamer, glyphs);
            //}

            // Read in the .xml files
            races = ReadInFromXml<List<Race>>(nameof(Race));
            gameClasses = ReadInFromXml<List<GameClass>>(nameof(GameClass));
            weapons = ReadInFromXml<List<Weapon>>(nameof(Weapon));
            weaponBlueprints = ReadInFromXml<List<WeaponBlueprint>>(nameof(WeaponBlueprint));
            weaponEnchants = ReadInFromXml<List<WeaponEnchant>>(nameof(WeaponEnchant));
            weaponUpgrades = ReadInFromXml<List<WeaponUpgrade>>(nameof(WeaponUpgrade));
            glyphs = ReadInFromXml<List<Glyph>>(nameof(Glyph));
            armors = ReadInFromXml<List<Armor>>(nameof(Armor));
            armorBlueprints = ReadInFromXml<List<ArmorBlueprint>>(nameof(ArmorBlueprint));
            armorEnchants = ReadInFromXml<List<ArmorEnchant>>(nameof(ArmorEnchant));

            // Set each weapon's "DisplayName" to the base name
            foreach (Weapon weapon in weapons)
            {
                weapon.DisplayName = weapon.Name;
            }

            // Create the enemy
            Enemy = new Enemy();
            random = new Random();
            PrintList = new List<Enemy>();
        }

        #endregion

        #region Properties

        public Enemy Enemy { get; set; }

        public List<Enemy> PrintList { get; set; }

        #endregion

        #region Methods

        #region Public Methods

        public void RandomizeEnemy()
        {
            double dRoll;
            SetDifficulty();

            // Select a Race
            Enemy.Race = races[random.Next(races.Count)];

            // Select a random GameClass avalable to this race
            string tmpClassOption = Enemy.Race.PossibleClassList[random.Next(Enemy.Race.PossibleClassList.Count)];

            // Select a GameClass
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (GameClass gameClass in gameClasses)
            {
                if (tmpClassOption == gameClass.Name)
                {
                    Enemy.GameClass = gameClass;
                    break;
                }
            }

            // Set stats

            // Set enemy level
            const int EasyOffset = 2;
            const int MediumOffset = 3;
            const int HardOffset = 5;

            dRoll = random.NextDouble();
            switch (Enemy.Difficulty)
            {
                case EnemyDifficulty.Easy:

                    // If dRoll > common, make the enemy's level offset less than average
                    if (dRoll > Common)
                    {
                        Enemy.Level = Enemy.AveragePlayerLevel - random.Next(0, EasyOffset);
                    }
                    else
                    {
                        Enemy.Level = Enemy.AveragePlayerLevel + random.Next(0, EasyOffset);
                    }
                    break;
                case EnemyDifficulty.Medium:

                    // If dRoll > uncommon, make the enemy's level offset less than average
                    if (dRoll > Uncommon)
                    {
                        Enemy.Level = Enemy.AveragePlayerLevel - random.Next(0, MediumOffset);
                    }
                    else
                    {
                        Enemy.Level = Enemy.AveragePlayerLevel + random.Next(0, MediumOffset);
                    }
                    break;
                case EnemyDifficulty.Hard:

                    // If dRoll > rare, make the enemy's level offset less than average
                    if (dRoll > Rare)
                    {
                        Enemy.Level = Enemy.AveragePlayerLevel - random.Next(0, HardOffset);
                    }
                    else
                    {
                        Enemy.Level = Enemy.AveragePlayerLevel + random.Next(0, HardOffset);
                    }
                    break;
            }

            // Calculate the XpYield
            const int ExtraEasyXp = 0;
            const int ExtraMediumXp = 3;
            const int ExtraHardXp = 7;
            switch (Enemy.Difficulty)
            {
                case EnemyDifficulty.Easy:
                    Enemy.XpYield = Enemy.Level + random.Next(0, ExtraEasyXp);
                    break;
                case EnemyDifficulty.Medium:
                    Enemy.XpYield = Enemy.Level + random.Next(0, ExtraMediumXp);
                    break;
                case EnemyDifficulty.Hard:
                    Enemy.XpYield = Enemy.Level + random.Next(0, ExtraHardXp);
                    break;
            }

            // Set health
            Enemy.Health = Enemy.Race.Health;

            // Set the 7 core stats
            Enemy.Dex = FindStat(Enemy.GameClass.DexGrade);
            Enemy.Acc = FindStat(Enemy.GameClass.AccGrade);
            Enemy.Str = FindStat(Enemy.GameClass.StrGrade);
            Enemy.Snek = FindStat(Enemy.GameClass.SnekGrade);
            Enemy.Percep = FindStat(Enemy.GameClass.PercepGrade);
            Enemy.MagicSkill = FindStat(Enemy.GameClass.MSkillGrade);
            Enemy.WeaponSkill = FindStat(Enemy.GameClass.WSkillGrade);


            // Select Weapons
            do
            {
                Enemy.Weapons = new List<Weapon>();

                // Select a random weapon avalable to this GameClass
                string tmpWeaponRight = Enemy.GameClass.PossibleWeaponsList[random.Next(Enemy.GameClass.PossibleWeaponsList.Count)];

                // Place a weapon in Weapons[0]
                // ReSharper disable once LoopCanBePartlyConvertedToQuery
                foreach (Weapon weapon in weapons)
                {
                    if (tmpWeaponRight == weapon.Name)
                    {
                        Enemy.Weapons.Add(new Weapon(weapon));
                        break;
                    }
                }

                // Roll to see if enemy has a second weapon

                double extraWeaponChance = 0;
                if (Enemy.GameClass.WSkillGrade == SkillGrade.Best)
                {
                    extraWeaponChance = 0.13;
                }

                dRoll = random.NextDouble();
                if (dRoll > Common + extraWeaponChance && !Enemy.Weapons[0].IsTwoHanded)
                {
                    // Loop until the second weapon is not a two handed weapon
                    do
                    {
                        // Select a random weapon avalable to this GameClass
                        string tmpWeaponLeft = Enemy.GameClass.PossibleWeaponsList[random.Next(Enemy.GameClass.PossibleWeaponsList.Count)];

                        // ReSharper disable once LoopCanBePartlyConvertedToQuery
                        foreach (Weapon weapon in weapons)
                        {
                            if (tmpWeaponLeft == weapon.Name)
                            {
                                Enemy.Weapons.Add(new Weapon(weapon));
                                break;
                            }
                        }
                    } while (!Enemy.Weapons[1].IsTwoHanded && Enemy.Weapons.Count == 1);
                }

            } while (!IsAcceptableWeaponCombo());

            // Select any/all weapon mods and apply them
            foreach (Weapon currentWeapon in Enemy.Weapons)
            {
                // Select WeaponEnchant
                dRoll = random.NextDouble();
                switch (Enemy.Difficulty)
                {
                    case EnemyDifficulty.Easy:
                        if (dRoll > Rare)
                        {
                            GiveWeaponEnchant(currentWeapon);
                        }
                        break;
                    case EnemyDifficulty.Medium:
                        if (dRoll > Uncommon)
                        {
                            GiveWeaponEnchant(currentWeapon);
                        }
                        break;
                    case EnemyDifficulty.Hard:
                        if (dRoll > Common)
                        {
                            GiveWeaponEnchant(currentWeapon);
                        }
                        break;
                }

                // Select WeaponUpgrade
                dRoll = random.NextDouble();
                switch (Enemy.Difficulty)
                {
                    case EnemyDifficulty.Easy:
                        if (dRoll > Rare)
                        {
                            GiveWeaponUpgrade(currentWeapon);
                        }
                        break;
                    case EnemyDifficulty.Medium:
                        if (dRoll > Uncommon)
                        {
                            GiveWeaponUpgrade(currentWeapon);
                        }
                        break;
                    case EnemyDifficulty.Hard:
                        if (dRoll > Common)
                        {
                            GiveWeaponUpgrade(currentWeapon);
                        }
                        break;
                }

                // Select WeaponBlueprint
                dRoll = random.NextDouble();
                switch (Enemy.Difficulty)
                {
                    case EnemyDifficulty.Easy:
                        if (dRoll > Rare)
                        {
                            GiveWeaponBlueprint(currentWeapon);
                        }
                        break;
                    case EnemyDifficulty.Medium:
                        if (dRoll > Uncommon)
                        {
                            GiveWeaponBlueprint(currentWeapon);
                        }
                        break;
                    case EnemyDifficulty.Hard:
                        if (dRoll > Common)
                        {
                            GiveWeaponBlueprint(currentWeapon);
                        }
                        break;
                }
            }

            // Select Glyphs

            // Build the list of POSSIBLE glyphs
            List<Glyph> tmpPossibleGlyphs = new List<Glyph>();
            if (Enemy.GameClass.MagType != MagicianType.NON)
            {
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (Glyph currentGlyph in glyphs)
                {
                    if (currentGlyph.LvlReq <= Enemy.MagicSkill && currentGlyph.School == Enemy.GameClass.MagType)
                    {
                        tmpPossibleGlyphs.Add(currentGlyph);
                    }
                }
            }

            Enemy.Glyphs = tmpPossibleGlyphs;

            // Choose which of those POSSIBLE glyphs the enemy will have
            if (Enemy.Glyphs.Count != 0)
            {
                AssembleFinalGlyphList();
            }

            // Select Armor

            // Select armor count
            int armorCount = 0;
            switch (Enemy.Difficulty)
            {
                case EnemyDifficulty.Easy:
                    armorCount = random.Next(0, 4);
                    break;
                case EnemyDifficulty.Medium:
                    armorCount = random.Next(1, 5);
                    break;
                case EnemyDifficulty.Hard:
                    armorCount = random.Next(3, 7);
                    break;
            }

            // Assemble armor list
            //while (Enemy.Armors.Count < armorCount)
            //{
                
            //}



            // Select ArmorBlueprint

            // Select ArmorEnchant

            // Select Loot

        }

        void SetDifficulty()
        {
            // Select difficulty
            double dRoll = random.NextDouble();
            if (dRoll > Rare)
            {
                Enemy.Difficulty = EnemyDifficulty.Hard;
            }
            else if (dRoll > Common)
            {
                Enemy.Difficulty = EnemyDifficulty.Medium;
            }
            else
            {
                Enemy.Difficulty = EnemyDifficulty.Easy;
            }
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods

        /// <summary>
        /// Reads in an xml file into a generic list taylored to that xml file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file"></param>
        /// <returns></returns>
        static T ReadInFromXml<T>(string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream($"{InputFolder}{file}List.xml", FileMode.Open))
            {
                return (T)serializer.Deserialize(stream);
            }
        }

        /// <summary>
        /// Finds a stat based off of enemy level and the passed in SkillGrade
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        int FindStat(SkillGrade grade)
        {
            // Local declarations
            int returnVal = 0;
            const int WorstOffset = -4;
            const int NormalOffset = -2;
            const int BestOffset = 2;
            int variability = 0;

            // Set variablility based on level bracket
            if (Enemy.Level > 0 && Enemy.Level < 10)
            {
                variability = 1;
            }
            else if (Enemy.Level >= 10 && Enemy.Level < 20)
            {
                variability = 3;
            }
            else if (Enemy.Level >= 20 && Enemy.Level < 30)
            {
                variability = 5;
            }
            else if (Enemy.Level >= 30 && Enemy.Level < 40)
            {
                variability = 7;
            }
            else if (Enemy.Level >= 40)
            {
                variability = 9;
            }

            // Set the stat
            switch (grade)
            {
                case SkillGrade.Worst:
                    returnVal = Enemy.Level + WorstOffset + random.Next(-variability, variability);
                    break;
                case SkillGrade.Normal:
                    returnVal = Enemy.Level + NormalOffset + random.Next(-variability, variability);
                    break;
                case SkillGrade.Best:
                    returnVal = Enemy.Level + BestOffset + random.Next(-variability, variability);
                    break;
                case SkillGrade.Non:
                    returnVal = 0;
                    break;
            }

            // Mop up negative values
            if (returnVal < 0)
            {
                returnVal = random.Next(3);
            }

            return returnVal;
        }

        /// <summary>
        /// Returns the boolean of if the current weapon combo is
        /// </summary>
        /// <returns></returns>
        bool IsAcceptableWeaponCombo()
        {
            bool returnVal = true;

            // Check to see if there's only one weapon
            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (Enemy.Weapons.Count == 2)
            {
                WeaponType tmpRType = Enemy.Weapons[0].WType;
                WeaponType tmpLType = Enemy.Weapons[1].WType;

                // Check for unacceptable weapon type combinations
                // ReSharper disable once ConvertIfStatementToSwitchStatement
                if (tmpRType == WeaponType.BowCross && tmpLType == WeaponType.BowCross)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.BowCross && tmpLType == WeaponType.BowNormal)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.BowNormal && tmpLType == WeaponType.BowCross)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.BowNormal && tmpLType == WeaponType.BowNormal)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.Shield && tmpLType == WeaponType.Shield)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.GunRifle && tmpLType == WeaponType.Shield)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.GunRifle && tmpLType == WeaponType.GunRifle)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.GunRifle && tmpLType == WeaponType.BowNormal)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.GunRifle && tmpLType == WeaponType.BowCross)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.BowNormal && tmpLType == WeaponType.GunRifle)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.BowCross && tmpLType == WeaponType.GunRifle)
                {
                    returnVal = false;
                }
                else if (tmpRType == WeaponType.Shield)
                {
                    returnVal = false;
                }
            }
            else if (Enemy.Weapons.Count == 1)
            {
                WeaponType tmpType = Enemy.Weapons[0].WType;

                // Check for unacceptable standalone weapon types
                if (tmpType == WeaponType.Shield)
                {
                    returnVal = false;
                }
            }

            return returnVal;
        }

        /// <summary>
        /// Gives a blueprint to the passed in weapon
        /// </summary>
        /// <returns></returns>
        void GiveWeaponEnchant(Weapon weapon)
        {
            WeaponEnchant enchant = weaponEnchants[random.Next(weaponEnchants.Count)];
            weapon.Enchant = enchant;
            weapon.DisplayName = $"({weapon.Enchant.Name}) {weapon.DisplayName}";
            weapon.Description = weapon.Enchant.Description;
        }

        /// <summary>
        /// Gives an upgrade to the passed in weapon based on diffaculty
        /// </summary>
        /// <returns></returns>
        void GiveWeaponUpgrade(Weapon weapon)
        {
            WeaponUpgrade upgrade;
            const double LocalCommon = 0.25;
            const double LocalUncommon = 0.5;
            const double BasiclyNever = 0.95;
            double dRoll;

            // Find a weapon upgrade apprpreate to the enemy diffaculty
            switch (Enemy.Difficulty)
            {
                case EnemyDifficulty.Easy:
                    dRoll = random.NextDouble();
                    if (dRoll > BasiclyNever)
                    {
                        upgrade = weaponUpgrades[2];
                    }
                    else if (dRoll > LocalUncommon)
                    {
                        upgrade = weaponUpgrades[1];
                    }
                    else
                    {
                        upgrade = weaponUpgrades[0];
                    }
                    break;
                case EnemyDifficulty.Medium:
                    dRoll = random.NextDouble();
                    if (dRoll > BasiclyNever)
                    {
                        upgrade = weaponUpgrades[3];
                    }
                    else if (dRoll > LocalUncommon)
                    {
                        upgrade = weaponUpgrades[2];
                    }
                    else
                    {
                        upgrade = weaponUpgrades[1];
                    }
                    break;
                default:
                    dRoll = random.NextDouble();
                    if (dRoll > BasiclyNever)
                    {
                        upgrade = weaponUpgrades[4];
                    }
                    else if (dRoll > LocalUncommon)
                    {
                        upgrade = weaponUpgrades[3];
                    }
                    else if (dRoll > LocalCommon)
                    {
                        upgrade = weaponUpgrades[2];
                    }
                    else
                    {
                        upgrade = weaponUpgrades[1];
                    }
                    break;
            }

            weapon.Upgrade = upgrade;
            weapon.DisplayName = $"{weapon.DisplayName} (+{upgrade.UpgradeVal})";
        }

        /// <summary>
        /// Gives a blueprint to the passed in weapon
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        void GiveWeaponBlueprint(Weapon weapon)
        {
            List<WeaponBlueprint> possibleBlueprints = new List<WeaponBlueprint>();

            // Create a list of possible weapon blueprints
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (WeaponBlueprint weaponBlueprint in weaponBlueprints)
            {
                if (weaponBlueprint.DestWeapon == weapon.Name)
                {
                    possibleBlueprints.Add(weaponBlueprint);
                }
            }

            // Select a random blueprint from that list of possible blueprints
            weapon.Blueprint = possibleBlueprints[random.Next(possibleBlueprints.Count)];

            // Change the Weapon Name
            weapon.DisplayName = $"{weapon.DisplayName} (***)";

            // Add the move
            weapon.WeaponMoves.Add(weapon.Blueprint.Move);
        }

        void AssembleFinalGlyphList()
        {
            const int EasyGlyphCount = 2;
            const int MediumGlyphCount = 3;
            const int HardGlyphCount = 5;

            // Set ExtraGlyphCount
            int extraGlyphCount = 0;
            switch (Enemy.GameClass.MSkillGrade)
            {
                case SkillGrade.Best:
                    extraGlyphCount = 2;
                    break;
                case SkillGrade.Normal:
                    extraGlyphCount = 1;
                    break;
            }

            List<Glyph> glyphsToActuallyHave = new List<Glyph>();
            Glyph tmpGlyph;

            // Assemble loop length
            int loopLength = 0;
            if (Enemy.Difficulty == EnemyDifficulty.Easy)
            {
                loopLength = EasyGlyphCount + extraGlyphCount;
            }
            if (Enemy.Difficulty == EnemyDifficulty.Medium)
            {
                loopLength = MediumGlyphCount + extraGlyphCount;
            }
            if (Enemy.Difficulty == EnemyDifficulty.Hard)
            {
                loopLength = HardGlyphCount + extraGlyphCount;
            }
            
            // Add the first glyph
            glyphsToActuallyHave.Add(Enemy.Glyphs[random.Next(Enemy.Glyphs.Count)]);

            // Add the rest of the glyphs
            while (glyphsToActuallyHave.Count < loopLength)
            {
                tmpGlyph = Enemy.Glyphs[random.Next(Enemy.Glyphs.Count)];
                if (!glyphsToActuallyHave.Contains(tmpGlyph))
                {
                    glyphsToActuallyHave.Add(tmpGlyph);
                }
                if (glyphsToActuallyHave.Count == Enemy.Glyphs.Count)
                {
                    break;
                }
            }

            // Add the final glyph list to the Enemy.Glyph list
            Enemy.Glyphs = glyphsToActuallyHave;
        }

        #endregion

        #endregion
    }
}