using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(kitchenLight);
            Stereo stereo = new Stereo();

            // Define and instantiate an Off and On command for each Vendor class
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff); // use high/off for demo
            remoteControl.SetCommand(3, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(4, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button
            Console.WriteLine("--- Pushing living room light ON ---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("--- Pushing living room light OFF ---");
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine("--- Undo last ---");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("--- Pushing kitchen light ON ---");
            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine("--- Pushing ceiling fan HIGH ---");
            remoteControl.OnButtonWasPushed(2);
            Console.WriteLine("--- Pushing stereo ON (CD) ---");
            remoteControl.OnButtonWasPushed(4);

            Console.WriteLine("--- Undo last 3 actions ---");
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("--- Macro command test: party on/off ---");
            Command[] partyOn = { livingRoomLightOn, stereoOnWithCd, ceilingFanHigh };
            Command[] partyOff = { livingRoomLightOff, stereoOff, ceilingFanOff };
            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(5, partyOnMacro, partyOffMacro);
            remoteControl.OnButtonWasPushed(5);
            Console.WriteLine("--- Undo macro ---");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("--- Multiple undo beyond history ---");
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("Testing completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}