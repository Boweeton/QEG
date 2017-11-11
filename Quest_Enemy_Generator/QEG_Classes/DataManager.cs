using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        readonly List<Armor> armors;

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

            // Set each weapon's "DisplayName" to the base name
            foreach (Weapon weapon in weapons)
            {
                weapon.DisplayName = weapon.Name;
            }

            // Create the enemy
            Enemy = new Enemy();
            random = new Random();
            RMode = RandomMode.Normal;
        }

        #endregion

        #region Properties

        public Enemy Enemy { get; set; }

        public List<Enemy> EnemyList { get; set; }

        public bool PrintWeaponsFull { get; set; }

        public bool PrintGlyphsFull { get; set; }

        public bool PrintArmorFull { get; set; }

        public RandomMode RMode { get; set; }

        #endregion

        #region Methods

        #region Public Methods

        public void FillEnemyList(int avgLevel, int enemyCount)
        {
            // Initialize the enemyList
            EnemyList = new List<Enemy>();

            for (int i = 0; i < enemyCount; i++)
            {
                RandomizeEnemy(avgLevel);
                EnemyList.Add(Enemy);
            }
        }

        public List<string> FormatListForDisplay()
        {
            List<string> returnList = new List<string>();

            foreach (Enemy enemy in EnemyList)
            {
                enemy.PrintFullWeapons = PrintWeaponsFull;
                enemy.PrintFullGlyphs = PrintGlyphsFull;
                enemy.PrintArmor = PrintArmorFull;
                returnList.Add(enemy.ToString());
            }

            return returnList;
        }

        public List<string> FormatListForTxtPrinting()
        {
            // Local declarations
            const int PageHeight = 47;
            List<string> returnList = new List<string>();

            int counter = 0;

            foreach (Enemy enemy in EnemyList)
            {
                enemy.PrintFullWeapons = PrintWeaponsFull;
                enemy.PrintFullGlyphs = PrintGlyphsFull;
                enemy.PrintArmor = PrintArmorFull;

                string enemyString = enemy.ToString();
                int currentHeight = CountLines(enemyString);

                if (currentHeight > PageHeight - counter)
                {
                    for (int i = 0; i < (PageHeight - counter) + 1; i++)
                    {
                        returnList.Add(" ");
                    }
                    counter = 0;
                }
                counter += currentHeight;

                returnList.Add(enemyString);
            }

            return returnList;
        }

        public void RandomizeEnemy(int averageLevel)
        {
            Enemy = new Enemy { AveragePlayerLevel = averageLevel };

            SetDifficulty(RMode);

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

            double dRoll = random.NextDouble();
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
            if (Enemy.GameClass.CanUseMagic)
            {
                // ReSharper disable once LoopCanBePartlyConvertedToQuery
                foreach (Glyph currentGlyph in glyphs)
                {
                    if (currentGlyph.LvlReq <= Enemy.MagicSkill && currentGlyph.School == Enemy.GameClass.MagType)
                    {
                        Enemy.Glyphs.Add(currentGlyph);
                    }
                }
            }

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
                    armorCount = random.Next(1, 4);
                    break;
                case EnemyDifficulty.Hard:
                    armorCount = random.Next(3, 5);
                    break;
            }

            // Assemble possibleArmor list
            Enemy.Armors = new List<Armor>();
            List<Armor> possibleArmors = new List<Armor>();

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (Armor currentArmor in armors)
            {
                if (currentArmor.IsLight == Enemy.GameClass.WearsLight)
                {
                    possibleArmors.Add(new Armor(currentArmor));
                }
            }

            // Add armors to current enemy
            Armor tmpArmor;
            while (Enemy.Armors.Count <= armorCount)
            {
                tmpArmor = possibleArmors[random.Next(possibleArmors.Count)];
                if (Enemy.Armors.All(armor => armor.AType != tmpArmor.AType))
                {
                    Enemy.Armors.Add(tmpArmor);
                }
            }

            // Decide armor def values
            foreach (Armor armor in Enemy.Armors)
            {
                switch (Enemy.Difficulty)
                {
                    case EnemyDifficulty.Easy:
                        armor.DefVal = random.Next(1, 3);
                        break;
                    case EnemyDifficulty.Medium:
                        armor.DefVal = random.Next(2, 5);
                        break;
                    case EnemyDifficulty.Hard:
                        armor.DefVal = random.Next(3, 6);
                        break;
                }
            }

            // Total up def values
            foreach (Armor armor in Enemy.Armors)
            {
                switch (armor.DType)
                {
                    case DefType.Physical:
                        Enemy.TotalPDef += armor.DefVal;
                        break;
                    case DefType.Glyph:
                        Enemy.TotalGDef += armor.DefVal;
                        break;
                }
            }

            // Sort the armors
            Enemy.Armors = Enemy.Armors.OrderBy(armor => armor.AType).ToList();

            // Select ArmorBlueprint

            // Select ArmorEnchant

            // Select Loot

            // Choose Scrips
            int tmpScrips = 0;

            // Add scrips based off diffaculty
            switch (Enemy.Difficulty)
            {
                case EnemyDifficulty.Easy:
                    tmpScrips += random.Next(0, 6);
                    break;
                case EnemyDifficulty.Medium:
                    tmpScrips += random.Next(5, 13);
                    break;
                case EnemyDifficulty.Hard:
                    tmpScrips += random.Next(10, 21);
                    break;
            }

            // Add scrips based off weapons
            tmpScrips += random.Next(Enemy.Weapons.Count - 1, Enemy.Weapons.Count + 3);

            // Add scrips based off glyphs
            if (Enemy.GameClass.CanUseMagic)
            {
                tmpScrips += random.Next(Enemy.Glyphs.Count - 1, Enemy.Glyphs.Count + 4);
            }

            // Add scrips based off armor
            tmpScrips += random.Next(Enemy.Armors.Count + 3, Enemy.Armors.Count + 7);

            Enemy.Scrips = tmpScrips;

        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods

        /// <summary>
        /// Returns how many line return characters are in the provided string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        int CountLines(string str)
        {
            return str.Length - str.Replace("\n", "").Length;
        }

        /// <summary>
        /// Sets the enemy diffaculty
        /// </summary>
        void SetDifficulty(RandomMode rMode)
        {
            // Declare probability constants
            const float MoreCommon = 0.68f;
            const float LessCommon = 0.9f;

            // Select difficulty
            double dRoll = random.NextDouble();
            switch (rMode)
            {
                case RandomMode.Normal:
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
                    break;
                case RandomMode.MoreEasy:
                    if (dRoll > LessCommon)
                    {
                        Enemy.Difficulty = EnemyDifficulty.Hard;
                    }
                    else if (dRoll > MoreCommon)
                    {
                        Enemy.Difficulty = EnemyDifficulty.Medium;
                    }
                    else
                    {
                        Enemy.Difficulty = EnemyDifficulty.Easy;
                    }
                    break;
                case RandomMode.MoreMedium:
                    if (dRoll > LessCommon)
                    {
                        Enemy.Difficulty = EnemyDifficulty.Hard;
                    }
                    else if (dRoll > MoreCommon)
                    {
                        Enemy.Difficulty = EnemyDifficulty.Easy;
                    }
                    else
                    {
                        Enemy.Difficulty = EnemyDifficulty.Medium;
                    }
                    break;
                case RandomMode.MoreHard:
                    if (dRoll > LessCommon)
                    {
                        Enemy.Difficulty = EnemyDifficulty.Easy;
                    }
                    else if (dRoll > MoreCommon)
                    {
                        Enemy.Difficulty = EnemyDifficulty.Medium;
                    }
                    else
                    {
                        Enemy.Difficulty = EnemyDifficulty.Hard;
                    }
                    break;
                case RandomMode.AllEasy:
                    Enemy.Difficulty = EnemyDifficulty.Easy;
                    break;
                case RandomMode.AllMedium:
                    Enemy.Difficulty = EnemyDifficulty.Medium;
                    break;
                case RandomMode.AllHard:
                    Enemy.Difficulty = EnemyDifficulty.Hard;
                    break;
            }
        }

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
            if (returnVal <= 0)
            {
                returnVal = random.Next(1, 3);
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

        /// <summary>
        /// Loads up glyphs based on possible glyphs
        /// </summary>
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

            List<Glyph> actualGlyphs = new List<Glyph>();

            // Assemble loop length
            int loopLength = 0;
            switch (Enemy.Difficulty)
            {
                case EnemyDifficulty.Easy:
                    loopLength = EasyGlyphCount + extraGlyphCount;
                    break;
                case EnemyDifficulty.Medium:
                    loopLength = MediumGlyphCount + extraGlyphCount;
                    break;
                case EnemyDifficulty.Hard:
                    loopLength = HardGlyphCount + extraGlyphCount;
                    break;
            }

            // Add the first glyph
            actualGlyphs.Add(Enemy.Glyphs[random.Next(Enemy.Glyphs.Count)]);

            // Add the rest of the glyphs
            while (actualGlyphs.Count < loopLength)
            {
                Glyph tmpGlyph = Enemy.Glyphs[random.Next(Enemy.Glyphs.Count)];
                if (!actualGlyphs.Contains(tmpGlyph))
                {
                    actualGlyphs.Add(tmpGlyph);
                }
                if (actualGlyphs.Count == Enemy.Glyphs.Count)
                {
                    break;
                }
            }

            // Add the final glyph list to the Enemy.Glyph list
            Enemy.Glyphs = actualGlyphs;
        }

        #endregion

        #endregion
    }
}