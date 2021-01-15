using Memory;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Solitairica_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Initiate new mem
        private Mem memory = new Mem();

        // Game Process name
        private const string ProcessName = "Solitairica-Win64-Shipping";

        // Addresse(s) of the thing(s) you want to modify
        private const string AttackAddress = "Solitairica-Win64-Shipping.exe+041169C0,130,318"; // Attack Points
        private const string DefenseAddress = "Solitairica-Win64-Shipping.exe+041169C0,130,31C"; // Defense Points
        private const string AgilityAddress = "Solitairica-Win64-Shipping.exe+041169C0,130,320"; // Agility Points
        private const string WillPowerAddress = "Solitairica-Win64-Shipping.exe+041169C0,130,324"; // Willpower Points

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Process
            _ = memory.OpenProcess(Process.GetProcessesByName(ProcessName).FirstOrDefault().Id);
            // Write modifications to the memory
            _ = memory.WriteMemory(
                code: AttackAddress,
                type: "int",
                write: numericUpDown1.Value.ToString());
            _ = memory.WriteMemory(
                code: DefenseAddress,
                type: "int",
                write: numericUpDown2.Value.ToString());
            _ = memory.WriteMemory(
                code: AgilityAddress,
                type: "int",
                write: numericUpDown3.Value.ToString());
            _ = memory.WriteMemory(
                code: WillPowerAddress,
                type: "int",
                write: numericUpDown4.Value.ToString());
        }

        // Addresse(s) of the thing(s) you want to modify
        private const string CoinsAddress = "Solitairica-Win64-Shipping.exe+04112488,8,218,190"; // Coins
        private const string GemsAddress = "Solitairica-Win64-Shipping.exe+040F4AD0,50,130,28"; // Gems

        private void button2_Click(object sender, EventArgs e)
        {
            // Open Process
            _ = memory.OpenProcess(Process.GetProcessesByName(ProcessName).FirstOrDefault().Id);
            // Write modifications to the memory
            _ = memory.WriteMemory(
                code: CoinsAddress,
                type: "int",
                write: numericUpDown5.Value.ToString());
            _ = memory.WriteMemory(
                code: GemsAddress,
                type: "int",
                write: numericUpDown6.Value.ToString());
        }
    }
}