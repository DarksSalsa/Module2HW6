using AppliancesModule;
using AppliancesModule.Services;
using AppliancesModule.TypesOfAppliances.Bathroom;
using AppliancesModule.TypesOfAppliances.Kitchen;
using AppliancesModule.TypesOfAppliances.Livingroom;

TV tv1 = new("Sony", 1995, 105, false);
TV tv2 = new("Alyx", 2015, 220, true);
VacuumCleaner vc = new("John&Stone", 2000, 40);
Fridge fr = new("Tyler", 2021, 220);
Kettle ke = new("Kettle", 1980, 30);
Dryer dr = new("TTS-14", 2022, 15);
Fan fn = new("ATX", 2005, 17);
WashingMachine wm = new("Dolly", 1998, 340);
ElectricAppliance[] set1 = new ElectricAppliance[] { tv2, fr, ke, dr, wm };
ElectricAppliance[] set2 = new ElectricAppliance[] { tv1, fn, ke, fr, vc };
ElectricAppliance[] set3 = new ElectricAppliance[] { tv1, tv2, vc ,fr, ke, dr, fn, wm};
set1.Flood();
set2.Flood();
set3.SortByVoltageArray();
//Tv methods
tv1.ChannelFrequency();
tv1.SwitchChannel();
tv1.ChannelFrequency();
//Dryer method
dr.Drying();
