using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.ProductRange.Any())
                content.ProductRange.AddRange( new ProductRange[]
                {
                    new ProductRange
                    {
                        VendorCode = "355GW-AMD5RYZEN2600OEM"
                    }, 
                    new ProductRange
                    {
                        VendorCode = "396GW-AMD5RYZEN3600OEM"
                    },
                    new ProductRange
                    {
                        VendorCode = "GV-N166SGAMING"
                    },
                    new ProductRange
                    {
                        VendorCode = "GV-RX580GAMING"
                    },
                    new ProductRange
                    {
                        VendorCode = "MK16A1"
                    },
                    new ProductRange
                    {
                        VendorCode = "RD185A7"
                    }
                });
            content.SaveChanges();

            if (!content.CPU.Any())
                content.CPU.AddRange(
                    new Processor
                    {
                        ProductRangeId = 1,
                        Name = "Процессор AMD Ryzen 5 2600",
                        Description = "Pinnacle Ridge, AM4, 6 ядер, частота 3.9/3.4 ГГц, кеш 3 МБ + 16 МБ," +
                        "техпроцесс 12 нм, TP 65W",
                        MarketEntryDate = "2018",
                        Cost = 320,
                        Socket = "AM4",
                        NumberCores = 6,
                        MaximumNumberThreads = 12,
                        Baseclock = "3.4 ГГц",
                        MaximumFrequency = "3.9 ГГЦ",
                        L2cache = "3 МБ",
                        L3cache = "16 МБ",
                        MemorySupport = "DDR4",
                        NumberOfChannels = "2",
                        MaxMemoryFrequency = "2993 МГц",
                        Image = "/img/CPU/amd.jpeg"
                    },
                    new Processor
                    {
                        ProductRangeId = 2,
                        Name = "Процессор AMD Ryzen 5 3600",
                        Description = "Matisse, AM4, 6 ядер, частота 4.2/3.6 ГГцб кэш 3 МБ + 32 МБ, техпроцесс 7 нм, TDP 65W",
                        MarketEntryDate = "2019-01",
                        Cost = 450,
                        Socket = "AM4",
                        NumberCores = 6,
                        MaximumNumberThreads = 12,
                        Baseclock = "3.6 ГГц",
                        MaximumFrequency = "4.2 ГГц",
                        L2cache = "3 МБ",
                        L3cache = "32 МБ",
                        MemorySupport = "DDR4",
                        NumberOfChannels = "2",
                        MaxMemoryFrequency = "3200 МГц",
                        Image = "/img/CPU/amd.jpeg"
                    });
            content.SaveChanges();

            if (!content.GPU.Any())
                content.GPU.AddRange(
                    new GraphicalCard
                    {
                        ProductRangeId = 3,
                        Name = "Видеокарта Gigabyte GeForce GTX 1660 Super",
                        Description = "NVIDIA GeForce GTX 1660 Super, базовая частота 1530 МГц, " +
                        "Turbo-частота 1860 МГц, 1408sp, частота памяти 3500 МГц, 192 бит, доп. питание: 8 pin, 2 слота, HDMI, DisplayPort",
                        Cost = 750,
                        MarketEntryDate = "2019",
                        Interface = "PCI Express x16 3.0",
                        Manufacturer = "NVIDIA",
                        GPU = "GeForce GTX 1660 Super",
                        OverclockedVersion = true,
                        Frequency = "1 530 МГц",
                        TurboFrequency = "1 860 МГц",
                        NumberOfStreamProcessors = 1408,
                        VideoMemory = "6 ГБ",
                        TypeMemory = "GDDR6",
                        MemoryFrequency = "3500 МГц",
                        MemoryBusWidth = 192,
                        Image = "/img/GPU/GigabyteGTX1660S.jpeg"
                    },
                    new GraphicalCard
                    {
                        ProductRangeId = 4,
                        Name = "Видеокарта Gigabyte Radeon RX 580",
                        Description = "AMD Radeon RX 580, базовая частота 1340 МГц, 2304sp, частота памяти," +
                        "2000 МГц, 256 бит, доп. питание: 8 pin, 2 слота, DVI, HDMI, DisplayPort",
                        Cost = 570,
                        MarketEntryDate = "2017",
                        Interface = "PCI Express x16 3.0",
                        Manufacturer = "AMD",
                        GPU = "Radeon RX 580",
                        OverclockedVersion = false,
                        Frequency = "1340 МГц",
                        NumberOfStreamProcessors = 2304,
                        VideoMemory = "8 ГБ",
                        TypeMemory = "GDDR5",
                        MemoryFrequency = "2000 МГц",
                        MemoryBusWidth = 256,
                        Image = "/img/GPU/GigabyteRX580.jpeg"
                    }
                );
            content.SaveChanges();
            if (!content.MB.Any())
                content.MB.AddRange(
                    new Motherboard
                    {
                        ProductRangeId = 5,
                        Name = "Материнская плата Gigabyte B450M DS3H (rev. 1.0)",
                        Description = "mATX, сокет AMD AM4, чипсет AMD B450, память 4хDDR4," +
                        "слоты: 2xPCIe x16, 1xPCIe x1, 1xM.2",
                        MarketEntryDate = "2018",
                        Cost = 190,
                        ProcessorSupport = "AMD",
                        Socket = "AM4",
                        Chipset = "AMD B450",
                        FormFactor = "mATX",
                        Backlight = false,
                        MemoryType = "DDR4",
                        MemorySlots = 4,
                        MaxMemoryCapacity = "64GB",
                        MemoryMode = "двухканальный",
                        MaxMemoryFrequency = "3600 МГц",
                        Image = "/img/MB/GigabyteB450MDS3H.jpeg"
                    },
                    new Motherboard
                    {
                        ProductRangeId = 6,
                        Name = "Материнская плата MSI MPG Z490 Gaming Plus",
                        Description = "ATX, сокет Intel LGA1200, чипсет Intel Z490, память 4xDDR4," +
                        "слоты: 2xPCIe x16, 3xPCIe x1, 2xM.2",
                        MarketEntryDate = "2020",
                        Cost = 500,
                        ProcessorSupport = "Intel",
                        Socket = "LGA1200",
                        Chipset = "Intel Z490",
                        FormFactor = "ATX",
                        Backlight = true,
                        MemoryType = "DDR4",
                        MemorySlots = 4,
                        MaxMemoryCapacity = "128GB",
                        MemoryMode = "двухканальный",
                        MaxMemoryFrequency = "48000 МГц",
                        Image = "/img/MB/MSIZ490GP.jpeg"
                    }
                );
            content.SaveChanges();
        }
    }
}
