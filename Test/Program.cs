using System;

namespace WiensWare.ComputerInfo.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serial: {0}", ComputerInfo.GetComputerSerialNumber());
            Console.WriteLine("Manufacturer: {0}", ComputerInfo.GetComputerManufacturer());
            Console.WriteLine("Model: {0}", ComputerInfo.GetComputerModel());
            Console.WriteLine("Name: {0}", ComputerInfo.GetComputerName());
            Console.WriteLine("Memory: {0}", ComputerInfo.GetMemory());
            Console.WriteLine("Clock Speed: {0}", ComputerInfo.GetClockSpeed());
            Console.WriteLine("Cache Size: {0}", ComputerInfo.GetCacheSize());
            Console.WriteLine("CPU Cores: {0}", ComputerInfo.GetCPUCores());
            Console.WriteLine("CPU Type: {0}", ComputerInfo.GetCPUType());
            Console.WriteLine("OS Version: {0}", ComputerInfo.GetOSversion());
            Console.WriteLine("OS Product Code: {0}", ComputerInfo.GetOSProductCode());
            Console.WriteLine("OS Name: {0}", ComputerInfo.GetOSName());
            Console.WriteLine("OS Type: {0}", ComputerInfo.GetOSType());
            Console.WriteLine("OS Install Date: {0}", ComputerInfo.GetOSInstallDate());
            Console.WriteLine("OS Architecture: {0}", ComputerInfo.GetOSArchitecture());
            Console.WriteLine("Current User: {0}", ComputerInfo.GetCurrentUser());
            Console.WriteLine("Current User: {0}", ComputerInfo.GetCurrentLoggedUser());
            Console.WriteLine("Computer Purpose: {0}", ComputerInfo.GetFullComputerType());
            Console.WriteLine("Computer Type: {0}", ComputerInfo.GetComputerType());
            Console.WriteLine("MAC Address: {0}", ComputerInfo.GetMACAddress());
            Console.WriteLine("IP Address: {0}", ComputerInfo.GetIPAddress());
            Console.WriteLine("Is Virtual Machine: {0}", ComputerInfo.IsVirtualMachine());

            Console.WriteLine("\nDrives:");
            Console.WriteLine("---------");
            foreach(DriveInfo drive in ComputerInfo.GetDrives())
            {
                Console.WriteLine("Drive {0} - Total Size {1} - Free Space {2}", drive.DriveLetter, drive.TotalSize, drive.FreeSpace);
            }

            Console.WriteLine("\nPrinters:");
            Console.WriteLine("----------");
            foreach (string printer in ComputerInfo.GetPrinters()) Console.WriteLine(printer);

            Console.WriteLine("\nMonitors:");
            Console.WriteLine("-----------");
            MonitorInfo[] monitors = ComputerInfo.GetMonitors();
            foreach(MonitorInfo info in monitors)
            {
                Console.WriteLine("{0} - {1}", monitors[0].Name, monitors[0].SerialNumber);
            }

            Console.WriteLine("\nSoftware:");
            Console.WriteLine("-----------");
            SoftwareInfo[] softwares = ComputerInfo.GetSoftwareInfo();
            foreach(SoftwareInfo software in softwares)
            {
                Console.WriteLine("{0} - {1} - {2}", software.Name, software.Version, software.Company);
            }

            Console.WriteLine("Press <ENTER> to exit.");
            Console.ReadLine();
        }
    }
}
