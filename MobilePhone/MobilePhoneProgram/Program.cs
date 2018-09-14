using MobilePhone;
using System;
using MobilePhone.MobileComponents.AudioJack;
using MobilePhone.MobilePhoneProgram;

namespace MobilePhoneProgram {
    class Program {
        static void Main(string[] args) {
            ConsoleOutput consoleOutput = new ConsoleOutput();
            SimCorpMobilePhone mobile = new SimCorpMobilePhone();
            consoleOutput.WriteLine(mobile.GetDescription());
            consoleOutput.WriteLine("Press any key to continue...");
            Console.ReadKey();
            var consolePlaybackComponent = new ConsolePlaybackComponent();
            IPlayback playbackComponent = consolePlaybackComponent.SelectPlaybackComponent(consoleOutput);
            mobile.PlaybackComponent = playbackComponent;
            consoleOutput.WriteLine("Set playback to Mobile...");
            mobile.Play();
            consoleOutput.WriteLine("Press any key to continue...");
            Console.ReadKey();
            var consoleChargerComponent = new ConsoleChargeComponent();
            mobile.ChargerComponent = consoleChargerComponent.SelectChargerComponent(consoleOutput);
            consoleOutput.WriteLine("Set charger to Mobile...");
            mobile.Charge();
            consoleOutput.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            consoleOutput.WriteLine(mobile.GetDescription());
        }
    }
}

