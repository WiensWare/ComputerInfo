using System;

namespace WiensWare.Computer.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serial: {0}", Info.GetComputerSerialNumber());
            Console.WriteLine("Manufacturer: {0}", Info.GetComputerManufacturer());
            Console.WriteLine("Model: {0}", Info.GetComputerModel());
            Console.WriteLine("Name: {0}", Info.GetComputerName());
            Console.WriteLine("Memory: {0}", Info.GetMemory());
            Console.WriteLine("Clock Speed: {0}", Info.GetClockSpeed());
            Console.WriteLine("Cache Size: {0}", Info.GetCacheSize());
            Console.WriteLine("CPU Cores: {0}", Info.GetCPUCores());
            Console.WriteLine("CPU Type: {0}", Info.GetCPUType());
            Console.WriteLine("OS Version: {0}", Info.GetOSversion());
            Console.WriteLine("OS Product Code: {0}", Info.GetOSProductCode());
            Console.WriteLine("OS Name: {0}", Info.GetOSName());
            Console.WriteLine("OS Type: {0}", Info.GetOSType());
            Console.WriteLine("OS Install Date: {0}", Info.GetOSInstallDate());
            Console.WriteLine("OS Architecture: {0}", Info.GetOSArchitecture());
            Console.WriteLine("Current User: {0}", Info.GetCurrentUser());
            Console.WriteLine("Current User: {0}", Info.GetCurrentLoggedUser());
            Console.WriteLine("Computer Purpose: {0}", Info.GetFullComputerType());
            Console.WriteLine("Computer Type: {0}", Info.GetComputerType());
            Console.WriteLine("MAC Address: {0}", Info.GetMACAddress());
            Console.WriteLine("IP Address: {0}", Info.GetIPAddress());
            Console.WriteLine("Is Virtual Machine: {0}", Info.IsVirtualMachine());

            Console.WriteLine("\nDrives:");
            Console.WriteLine("---------");
            foreach(DriveInfo drive in Info.GetDrives())
            {
                Console.WriteLine("Drive {0} - Total Size {1} - Free Space {2}", drive.DriveLetter, drive.TotalSize, drive.FreeSpace);
            }

            Console.WriteLine("\nPrinters:");
            Console.WriteLine("----------");
            foreach (string printer in Info.GetPrinters()) Console.WriteLine(printer);

            Console.WriteLine("\nMonitors:");
            Console.WriteLine("-----------");
            MonitorInfo[] monitors = Info.GetMonitors();
            foreach(MonitorInfo info in monitors)
            {
                Console.WriteLine("{0} - {1}", monitors[0].Name, monitors[0].SerialNumber);
            }

            Console.WriteLine("\nSoftware:");
            Console.WriteLine("-----------");
            SoftwareInfo[] softwares = Info.GetSoftwareInfo();
            foreach(SoftwareInfo software in softwares)
            {
                string bitness = "32-bit";
                if (software.Is64bit) bitness = "64-bit";
                Console.WriteLine("{0} - {1} - {2} - {3}", software.Name, software.Version, software.Company, bitness);
            }

            Console.WriteLine("Press <ENTER> to exit.");
            Console.ReadLine();
        }
    }
}
