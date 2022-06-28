using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using NoMansSky.Api;
using libMBIN.NMS.Globals;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.BNSReloaed
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : NMSMod
    {
        /// <summary>
        /// Initializes your mod along with some necessary info.
        /// </summary>
        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            // This is how to log a message to the Reloaded II Console.
            Logger.WriteLine("Hello World!");


            // The API relies heavily on Mod Events.
            // Below are 3 examples of using them.
            Game.OnProfileSelected += () => Logger.WriteLine("The player just selected a save file");
            Game.OnMainMenu += OnMainMenu;
            Game.OnGameJoined.AddListener(GameJoined);
        }

        /// <summary>
        /// Called once every frame.
        /// </summary>
        public override void Update()
        {
            // Here is an example of checking for keyboard keys
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                Logger.WriteLine("The Up Arrow was just pressed!");
            }

            if(Keyboard.IsPressed(Key.DownArrow))
            {
                settlementGlobals();


            }
        }

        private void OnMainMenu()
        {
            Logger.WriteLine("Main Menu shown!");


            //GlobalMbinModding();
            settlementGlobals();
        }

        // here is an example of modding globals with the new MemoryManager
        private void GlobalMbinModding()
        {
            var memoryMgr = new MemoryManager(); // create a memory manager.

            // example of getting the run speed from the player globals
            float currentRunSpeed = memoryMgr.GetValue<float>("GcPlayerGlobals.GroundRunSpeed");

            // example of settng the run speed to twice it's original value.
            memoryMgr.SetValue("GcPlayerGlobals.GroundRunSpeed", currentRunSpeed * 2);
        }

        private void settlementGlobals()
        {

            var memMgr = new MemoryManager();

            memMgr.SetValue("GcSettlementGlobals.JudgementWaitTimeMin", 90);
            memMgr.SetValue("GcSettlementGlobals.JudgementWaitTimeMax", 320);

            int minJudgeTime = memMgr.GetValue<int>("GcSettlementGlobals.JudgementWaitTimeMin");
            int maxJudgeTime = memMgr.GetValue<int>("GcSettlementGlobals.JudgementWaitTimeMax");

            Logger.WriteLine($"Min Judgement Time is: {minJudgeTime.ToString()}, Whilst Max Judge Time Is {maxJudgeTime.ToString()}");

            
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[37]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[38]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[39]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[40]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[41]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[42]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[43]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[44]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[45]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[46]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[47]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[48]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[49]", 30);
            memMgr.SetValue("GcSettlementGlobals.SettlementBuildingTimes[50]", 30);
            


        }

        private void GameJoined()
        {
            Logger.WriteLine("The game was joined!");
        }
    }
}