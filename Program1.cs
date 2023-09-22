
public abstract class SportEquipmentBase    //главный класс спортинвентарь
{
    public double Weight{ get; set;}        //свойство масса объеденяющее весь спорт инвентарь
}


public abstract class ElectrodependentEquipment: SportEquipmentBase{   //электрозависимое оборудование относится к главному классу
    public int Voltage { get; set;}      // напряжение, это свойство есть у всех электрозависимых
    public string Modes {get; set;}      // режимы, это свойство есть у всех электрозависимых
}

public class ExerciseBike: ElectrodependentEquipment{       //велодорожка относится к электрозависимым
    public string Load {get; set;}   //свойство нагрузка которое осталось у велодорожки
}

public class RunningTrack: ElectrodependentEquipment{      //беговая дорожка относится к электрозависимым
    public string Load {get; set;}  //свойтво нагрузка которое осталось у беговой дорожки
    public double Length {get; set;}     //свойтво длинна которое осталось у беговой дорожки
}


public abstract class SlopeProperty: SportEquipmentBase{  //свойство наклон относится к главному классу
    public int Incline {get; set;}  //свойство наклон объеденяющее скамейку и римский стул
}

public class Bench: SlopeProperty{    // скамейка относится к свойству наклон
    public string Load {get; set;}  //свойтво нагрузка которое осталось у скамейки
    public double MaxUsWeightWithWeights {get; set;}  // свойство максимальный вес пользователя с утяжелением которое осталось у скамейки
}

public class RomanChair: SlopeProperty{   //римский стул относится к свойству наклон
    public string Load {get; set;}    //свойтво нагрузка которое осталось у римского стула
    public double Size {get; set;}   //свойство размер которое осталось у римского стула
}


public abstract class HorizontalBar: SportEquipmentBase{  //турник относится к главному классу
    public bool Crossbar {get; set;}   //свойство наличие перекладины которое осталось у турника
    public bool Bars {get; set;}   //свойство наличие брусьев которое осталось у турника
}