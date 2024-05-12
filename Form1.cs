using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace RolPlayerCreator
{
    public partial class Form1 : Form
    {
        const int imageWidth = 277, imageHeight = 295;
        Character cha = new Character();
        int classSTR, classDEX, classCOS, classINT, classWIS, classCHA;
        public class Character
        {
            private string name, playerName, chaClass, subClass, race, hitDice, alignment, str, dex, intt, cos, cha, wis, armor, level, speed, background, traits;
            private Weapon weapon1, weapon2, weapon3;
            public string Str { get; set; }
            public string Dex { get; set; }
            public string Intt { get; set; }
            public string Cos { get; set; }
            public string Cha { get; set; }
            public string Wis { get; set; }
            public string Armor { get; set; }
            public string Level { get; set; }
            public string Alignment { get; set; }
            public string Speed { get; set; }
            public string Race { get; set; }
            public string HitDice { get; set; }
            public string Name { get; set; }
            public string PlayerName { get; set; }
            public string ChaClass { get; set; }
            public string SubClass { get; set; }
            public string Background { get; set; }
            public string Traits { get; set; }
            public Weapon Weapon1 { get; set; }
            public Weapon Weapon2 { get; set; }
            public Weapon Weapon3 { get; set; }

        }
        public class Weapon
        {
            private string nombre, atkBonus, atkDmg;


            public string Nombre { get; set; }
            public string AtkBonus { get; set; }
            public string AtkDmg { get; set; }

        }
        public Form1()
        {
            InitializeComponent();
            finalTraitsTxt.ScrollBars = ScrollBars.Vertical;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateFinal();
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            subClassComboBox.Items.Clear();
            subClassComboBox.Text = string.Empty;
            classSTR = 0;
            classCHA = 0;
            classCOS = 0;
            classWIS = 0;
            classINT = 0;
            classDEX = 0;
            string selection = classComboBox.Text;
            switch (selection)
            {
                case "Bárbaro":
                    subClassComboBox.Items.Add("Camino del Asesino");
                    subClassComboBox.Items.Add("Camino del Bersérker");
                    subClassComboBox.Items.Add("Camino del Guerrero Totémico");
                    subClassComboBox.Items.Add("Camino de los Guardianes Ancestrales");
                    subClassComboBox.Items.Add("Camino del Tótem del Oso");
                    classSTR = 2;

                    break;
                case "Bardo":
                    subClassComboBox.Items.Add("Colegio de la Espada");
                    subClassComboBox.Items.Add("Colegio de la Canción");
                    subClassComboBox.Items.Add("Colegio de la Valía");
                    subClassComboBox.Items.Add("Colegio de los Conocimientos");
                    subClassComboBox.Items.Add("Colegio de los Susurros");
                    classDEX = 2;
                    classCHA = 1;
                    break;
                case "Brujo":
                    subClassComboBox.Items.Add("Pacto del Archifey");
                    subClassComboBox.Items.Add("Pacto del Cuervo");
                    subClassComboBox.Items.Add("Pacto de la Cadena");
                    subClassComboBox.Items.Add("Pacto del Loco");
                    subClassComboBox.Items.Add("Pacto del la Espada");
                    subClassComboBox.Items.Add("Pacto del Genio");
                    classCHA = 2;
                    classWIS = 1;
                    break;
                case "Mago":
                    subClassComboBox.Items.Add("Escuela de Evocación");
                    subClassComboBox.Items.Add("Escuela de Ilusión");
                    subClassComboBox.Items.Add("Escuela de Abjuración");
                    subClassComboBox.Items.Add("Escuela de Nigromancia");
                    subClassComboBox.Items.Add("Escuela de Transmutación");
                    classINT = 2;
                    classWIS = 1;
                    break;
                case "Guerrero":
                    subClassComboBox.Items.Add("Arquetipo del Campeón");
                    subClassComboBox.Items.Add("Arquetipo del Maestro de Armas");
                    subClassComboBox.Items.Add("Arquetipo del Defensor");
                    subClassComboBox.Items.Add("Arquetipo del Espadachín");
                    subClassComboBox.Items.Add("Arquetipo del Inmortal");
                    classSTR = 2;
                    classCOS = 1;
                    break;
                case "Clérigo":
                    subClassComboBox.Items.Add("Dominio de la Luz");
                    subClassComboBox.Items.Add("Dominio de la Vida");
                    subClassComboBox.Items.Add("Dominio de la Guerra");
                    subClassComboBox.Items.Add("Dominio de la Tempestad");
                    subClassComboBox.Items.Add("Dominio de la Muerte");
                    classWIS = 2;
                    classCHA = 1;
                    break;
                case "Druida":
                    subClassComboBox.Items.Add("Círculo de la Tierra");
                    subClassComboBox.Items.Add("Círculo de la Luna");
                    subClassComboBox.Items.Add("Círculo de los Guardianes");
                    subClassComboBox.Items.Add("Círculo de los Sueños");
                    subClassComboBox.Items.Add("Círculo de las Cenizas");
                    classWIS = 2;
                    classCOS = 1;
                    break;
                case "Monje":
                    subClassComboBox.Items.Add("Camino del Puño Abierto");
                    subClassComboBox.Items.Add("Camino del Camino de la Sombra");
                    subClassComboBox.Items.Add("Camino del Camino del Viento");
                    subClassComboBox.Items.Add("Camino del Cuatro Elementos");
                    subClassComboBox.Items.Add("Camino del Alma");
                    classDEX = 2;
                    classWIS = 1;
                    break;
                case "Paladín":
                    subClassComboBox.Items.Add("Juramento de Devoción");
                    subClassComboBox.Items.Add("Juramento del Vengador");
                    subClassComboBox.Items.Add("Juramento de los Antiguos");
                    subClassComboBox.Items.Add("Juramento de la Conquista");
                    subClassComboBox.Items.Add("Juramento de la Redención");
                    classSTR = 2;
                    classCHA = 1;
                    break;
                case "Pícaro":
                    subClassComboBox.Items.Add("Arquetipo del Asesino");
                    subClassComboBox.Items.Add("Arquetipo del Ladrón");
                    subClassComboBox.Items.Add("Arquetipo del Pícaro Arcano");
                    subClassComboBox.Items.Add("Arquetipo del Pícaro Inquisitivo");
                    subClassComboBox.Items.Add("Arquetipo del Pícaro Maestro en Venenos");
                    classDEX = 2;
                    classINT = 1;
                    break;
                case "Hechicero":
                    subClassComboBox.Items.Add("Origen Draconiano");
                    subClassComboBox.Items.Add("Origen Salvaje");
                    subClassComboBox.Items.Add("Origen de la Sombra");
                    subClassComboBox.Items.Add("Origen de las Estrellas");
                    subClassComboBox.Items.Add("Origen del Caos");
                    classCHA = 2;
                    classCOS = 1;
                    break;
                case "Warlock":
                    subClassComboBox.Items.Add("Pacto del Archivista");
                    subClassComboBox.Items.Add("Pacto del Cuervo");
                    subClassComboBox.Items.Add("Pacto de la Cadena");
                    subClassComboBox.Items.Add("Pacto del Loco");
                    subClassComboBox.Items.Add("Pacto del Genio");
                    classCHA = 2;
                    classWIS = 1;
                    break;
                default:
                    break;
            }
        }
        private int updateHP(int dice)
        {
            Random random = new Random();
            int diceValor;
            return diceValor = random.Next(1, dice + 1);
        }
        private void updateHitDice()
        {
            string selection = classComboBox.Text;
            switch (selection)
            {
                case "Bárbaro":
                    finalHitDice.Text = $"{levelComboBox.Text}d12{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(12) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Bardo":
                    finalHitDice.Text = $"{levelComboBox.Text}d8{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(8) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Brujo":
                    finalHitDice.Text = $"{levelComboBox.Text}d8{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(8) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Mago":
                    finalHitDice.Text = $"{levelComboBox.Text}d6{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(6) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Guerrero":
                    finalHitDice.Text = $"{levelComboBox.Text}d10{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(10) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Clérigo":
                    finalHitDice.Text = $"{levelComboBox.Text}d8{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(8) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Druida":
                    finalHitDice.Text = $"{levelComboBox.Text}d8{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(8) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Monje":
                    finalHitDice.Text = $"{levelComboBox.Text}d8{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(8) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Paladín":
                    finalHitDice.Text = $"{levelComboBox.Text}d10{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(10) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Pícaro":
                    finalHitDice.Text = $"{levelComboBox.Text}d8{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(8) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Hechicero":
                    finalHitDice.Text = $"{levelComboBox.Text}d6{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(6) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
                case "Warlock":
                    finalHitDice.Text = $"{levelComboBox.Text}d8{finalCOSMod.Text}";
                    finalHP.Text = Convert.ToString(int.Parse(levelComboBox.Text) * updateHP(8) + (int.Parse(finalCOSMod.Text) * (int.Parse(levelComboBox.Text))));
                    break;
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string importTraits(Character cha)
        {
            string chaTraits = cha.Traits;
            string[] traits = chaTraits.Split(";");
            return string.Join("\r\n", traits);
        }
        private string saveTraits()
        {
            string[] featuresAndTraits = finalTraitsTxt.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string traits = string.Join(";", featuresAndTraits);
            return traits;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cha.Name = finalName.Text;
                cha.PlayerName = finalPlayerName.Text;
                cha.Level = finalLevel.Text;
                cha.Cos = finalCOS.Text;
                cha.Dex = finalDEX.Text;
                cha.Wis = finalWIS.Text;
                cha.Str = finalSTR.Text;
                cha.Intt = finalINT.Text;
                cha.Armor = finalArmor.Text;
                cha.Cha = finalCHA.Text;
                cha.Background = finalBackground.Text;
                cha.Alignment = finalAlignment.Text;
                cha.Race = finalRace.Text;
                cha.HitDice = finalHitDice.Text;
                cha.Speed = finalSpeed.Text;
                cha.ChaClass = finalClass.Text;
                Weapon w1 = new Weapon();
                Weapon w2 = new Weapon();
                Weapon w3 = new Weapon();
                w1.Nombre = finalWeapon1Name.Text;
                w2.Nombre = finalWeapon2Name.Text;
                w3.Nombre = finalWeapon3Name.Text;
                w1.AtkBonus = finalAtkBonus1.Text;
                w2.AtkBonus = finalAtkBonus2.Text;
                w3.AtkBonus = finalAtkBonus3.Text;
                w1.AtkDmg = finalAtkDMG1.Text;
                w2.AtkDmg = finalAtkDMG2.Text;
                w3.AtkDmg = finalAtkDMG3.Text;
                cha.Weapon1 = w1;
                cha.Weapon2 = w2;
                cha.Weapon3 = w3;
                cha.Traits = saveTraits();
                string directory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                string jsonString = JsonSerializer.Serialize(cha);
                string folderName = "Personajes";
                string folderPath = Path.Combine(directory, folderName);
                try
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine("Carpeta creada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}");

                }
                File.WriteAllText($"{folderPath}/{cha.Name}.json", jsonString);
                MessageBox.Show($"{cha.Name} guardado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SAVE ERR {ex.Message}");
            }

        }
        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos JSON|*.json|Todos los archivos|*.*";
            file.Title = "Seleccione su personaje";
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(file.FileName);
                    Character cha = JsonSerializer.Deserialize<Character>(jsonString);
                    finalName.Text = cha.Name;
                    finalLevel.Text = cha.Level;
                    finalClass.Text = cha.ChaClass;
                    finalPlayerName.Text = cha.PlayerName;
                    finalRace.Text = cha.Race;
                    finalAlignment.Text = cha.Alignment;
                    finalHitDice.Text = cha.HitDice;
                    finalArmor.Text = cha.Armor;
                    finalSTR.Text = cha.Str;
                    finalDEX.Text = cha.Dex;
                    finalINT.Text = cha.Intt;
                    finalCOS.Text = cha.Cos;
                    finalCHA.Text = cha.Cha;
                    finalWIS.Text = cha.Wis;
                    finalSpeed.Text = cha.Speed;
                    finalBackground.Text = cha.Background;
                    finalSTRMod.Text = calculateMods(cha.Str);
                    finalDEXMod.Text = calculateMods(cha.Dex);
                    finalINTMod.Text = calculateMods(cha.Intt);
                    finalCOSMod.Text = calculateMods(cha.Cos);
                    finalCHAMod.Text = calculateMods(cha.Cha);
                    finalWISMod.Text = calculateMods(cha.Wis);
                    finalInitiative.Text = finalDEXMod.Text;
                    switch (finalWISMod.Text)
                    {
                        case "-1":
                            finalPassiveWIS.Text = $"{10 - 1}";
                            break;
                        case "0":
                            finalPassiveWIS.Text = "10";
                            break;
                        case "+1":
                            finalPassiveWIS.Text = $"{10 + 1}";
                            break;
                        case "+2":
                            finalPassiveWIS.Text = $"{10 + 2}";
                            break;
                        case "+3":
                            finalPassiveWIS.Text = $"{10 + 3}";
                            break;
                        case "+4":
                            finalPassiveWIS.Text = $"{10 + 4}";
                            break;
                        case "+5":
                            finalPassiveWIS.Text = $"{10 + 5}";
                            break;
                        default:
                            finalPassiveWIS.Text = "ERROR";
                            break;
                    }
                    name.Text = finalName.Text;
                    playerName.Text = finalPlayerName.Text;
                    STRComboBox.Text = finalSTR.Text;
                    DEXComboBox.Text = finalDEX.Text;
                    INTComboBox.Text = finalINT.Text;
                    COSComboBox.Text = finalCOS.Text;
                    CHAComboBox.Text = finalCHA.Text;
                    WISComboBox.Text = finalWIS.Text;

                    classComboBox.SelectedText = finalClass.Text.Substring(0, finalClass.Text.IndexOf('['));
                    int subClassStart = finalClass.Text.IndexOf(" [");
                    int subClassEnd = finalClass.Text.IndexOf(']');
                    subClassComboBox.SelectedText = finalClass.Text.Substring(subClassStart, subClassEnd - subClassStart);



                    raceComboBox.Text = finalRace.Text;
                    backgroundComboBox.Text = finalBackground.Text;
                    levelComboBox.Text = finalLevel.Text;
                    alignmentComboBox.Text = finalAlignment.Text;
                    armor.Text = finalArmor.Text;
                    finalProfincency.Text = CalculateProficency(cha.Level);
                    finalWeapon1Name.Text = cha.Weapon1.Nombre;
                    finalWeapon2Name.Text = cha.Weapon2.Nombre;
                    finalWeapon3Name.Text = cha.Weapon3.Nombre;
                    finalAtkBonus1.Text = cha.Weapon1.AtkBonus;
                    finalAtkBonus2.Text = cha.Weapon2.AtkBonus;
                    finalAtkBonus3.Text = cha.Weapon3.AtkBonus;
                    finalAtkDMG1.Text = cha.Weapon1.AtkDmg;
                    finalAtkDMG2.Text = cha.Weapon2.AtkDmg;
                    finalAtkDMG3.Text = cha.Weapon3.AtkDmg;
                    weapon1NameTxt.Text = cha.Weapon1.Nombre;
                    weapon2NameTxt.Text = cha.Weapon2.Nombre;
                    weapon3NameTxt.Text = cha.Weapon3.Nombre;
                    weapon1AtkBonusTxt.Text = cha.Weapon1.AtkBonus;
                    weapon2AtkBonusTxt.Text = cha.Weapon2.AtkBonus;
                    weapon3AtkBonusTxt.Text = cha.Weapon3.AtkBonus;
                    weapon1AtkDmgTxt.Text = cha.Weapon1.AtkDmg;
                    weapon2AtkDmgTxt.Text = cha.Weapon2.AtkDmg;
                    weapon3AtkDmgTxt.Text = cha.Weapon3.AtkDmg;
                    finalTraitsTxt.Text = importTraits(cha);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}");
                }
            }

        }


        private void updateFinal()
        {
            //update stats and attributes 
            finalName.Text = name.Text;
            finalLevel.Text = levelComboBox.Text;
            finalClass.Text = classComboBox.Text;
            //AÑADIR MODIFICADORES POR CLASE
            finalPlayerName.Text = playerName.Text;
            finalRace.Text = raceComboBox.Text;
            finalAlignment.Text = alignmentComboBox.Text;
            finalArmor.Text = armor.Text;
            if ((classSTR == 0) && (classDEX == 0) && (classCOS == 0) && (classINT == 0) && (classWIS == 0) && (classCHA == 0))
            {
                finalSTR.Text = STRComboBox.Text;
                finalDEX.Text = DEXComboBox.Text;
                finalINT.Text = INTComboBox.Text;
                finalCOS.Text = COSComboBox.Text;
                finalCHA.Text = CHAComboBox.Text;
                finalWIS.Text = WISComboBox.Text;
                MessageBox.Show("Atributos añadidos sin modificador de clase");
            }
            else
            {
                finalSTR.Text = Convert.ToString(int.Parse(STRComboBox.Text) + classSTR);
                finalDEX.Text = Convert.ToString(int.Parse(DEXComboBox.Text) + classDEX);
                finalCOS.Text = Convert.ToString(int.Parse(COSComboBox.Text) + classCOS);
                finalINT.Text = Convert.ToString(int.Parse(INTComboBox.Text) + classINT);
                finalWIS.Text = Convert.ToString(int.Parse(WISComboBox.Text) + classWIS);
                finalCHA.Text = Convert.ToString(int.Parse(CHAComboBox.Text) + classCHA);
                MessageBox.Show("Atributos añadidos con modificador de clase");
            }

            finalBackground.Text = backgroundComboBox.Text;
            finalSTRMod.Text = calculateMods(finalSTR.Text);
            finalDEXMod.Text = calculateMods(finalDEX.Text);
            finalINTMod.Text = calculateMods(finalINT.Text);
            finalCOSMod.Text = calculateMods(finalCOS.Text);
            finalCHAMod.Text = calculateMods(finalCHA.Text);
            finalWISMod.Text = calculateMods(finalWIS.Text);
            finalInitiative.Text = finalDEXMod.Text;
            switch (finalWISMod.Text)
            {
                case "-1":
                    finalPassiveWIS.Text = $"{10 - 1}";
                    break;
                case "0":
                    finalPassiveWIS.Text = "10";
                    break;
                case "+1":
                    finalPassiveWIS.Text = $"{10 + 1}";
                    break;
                case "+2":
                    finalPassiveWIS.Text = $"{10 + 2}";
                    break;
                case "+3":
                    finalPassiveWIS.Text = $"{10 + 3}";
                    break;
                case "+4":
                    finalPassiveWIS.Text = $"{10 + 4}";
                    break;
                case "+5":
                    finalPassiveWIS.Text = $"{10 + 5}";
                    break;
                default:
                    finalPassiveWIS.Text = "ERROR";
                    break;
            }

            finalProfincency.Text = CalculateProficency(levelComboBox.Text);
            //update weapons
            finalWeapon1Name.Text = weapon1NameTxt.Text;
            finalWeapon2Name.Text = weapon2NameTxt.Text;
            finalWeapon3Name.Text = weapon3NameTxt.Text;
            finalAtkBonus1.Text = weapon1AtkBonusTxt.Text;
            finalAtkBonus2.Text = weapon2AtkBonusTxt.Text;
            finalAtkBonus3.Text = weapon3AtkBonusTxt.Text;
            finalAtkDMG1.Text = weapon1AtkDmgTxt.Text;
            finalAtkDMG2.Text = weapon2AtkDmgTxt.Text;
            finalAtkDMG3.Text = weapon3AtkDmgTxt.Text;
            finalClass.Text += $" [{subClassComboBox.Text}]";
            updateHitDice();
        }
        private string calculateMods(string stat)
        {
            try
            {
                int numStat = int.Parse(stat);
                switch (numStat)
                {
                    case 3:
                        return "-4";
                    case 4:
                    case 5:
                        return "-3";
                    case 6:
                    case 7:
                        return "-2";
                    case 8:
                    case 9:
                        return "-1";
                    case 10:
                    case 11:
                        return "0";
                    case 12:
                    case 13:
                        return "+1";
                    case 14:
                    case 15:
                        return "+2";
                    case 16:
                    case 17:
                        return "+3";
                    case 18:
                    case 19:
                        return "+4";
                    case 20:
                        return "+5";
                    default:
                        return "ERR";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
            return "ERR";


        }
        private string CalculateProficency(string stat)
        {
            int numStat = int.Parse(stat);
            switch (numStat)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    return "+2";
                case 5:
                case 6:
                case 7:
                case 8:
                    return "+3";
                case 9:
                case 10:
                case 11:
                case 12:
                    return "+4";
                case 13:
                case 14:
                case 15:
                case 16:
                    return "+5";
                case 17:
                case 18:
                case 19:
                case 20:
                    return "+6";
                default:
                    return "ERR";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = $"Seleccionar imagen para {finalName.Text}";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image ima = Image.FromFile(openFileDialog.FileName);
                    if ((ima.Width == 227) && (ima.Height == 297))
                    {
                        finalImage.Image = ima;
                        MessageBox.Show("Imagen cambiada!");
                    }
                    else
                    {
                        MessageBox.Show("La imagen debe ser 227x297 (WxH)");
                        MessageBox.Show($"Actualmente es {ima.Width}x{ima.Height}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string treat = Interaction.InputBox("Ingrese la característica o rasgo:", "Añadir característica o rasgo");
            if (!string.IsNullOrEmpty(treat))
            {
                finalTraitsTxt.Text = finalTraitsTxt.Text + "\r\n" + treat;
                MessageBox.Show("Añadido!");
            }
            else
            {
                MessageBox.Show("Ingrese una característica o rasgo");
            }
        }


        private static int CalculateAttributes()
        {
            Random random = new Random();
            int[] dices = new int[4];
            dices[0] = random.Next(1, 7);
            dices[1] = random.Next(1, 7);
            dices[2] = random.Next(1, 7);
            dices[3] = random.Next(1, 7);
            Array.Sort(dices);
            return (dices[1] + dices[2] + dices[3]);
        }


        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            STRComboBox.Text = Convert.ToString(CalculateAttributes());
            DEXComboBox.Text = Convert.ToString(CalculateAttributes());
            INTComboBox.Text = Convert.ToString(CalculateAttributes());
            COSComboBox.Text = Convert.ToString(CalculateAttributes());
            CHAComboBox.Text = Convert.ToString(CalculateAttributes());
            WISComboBox.Text = Convert.ToString(CalculateAttributes());
        }

        private void finalHitDice_TextChanged(object sender, EventArgs e)
        {

        }

        private void subClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
