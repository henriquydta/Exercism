class RemoteControlCar
{
    private readonly int _speed;
    private readonly int _batteryDrain;
    private int _battery = 100;
    private int _distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _battery < _batteryDrain;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (BatteryDrained()) return;
        _distanceDriven += _speed;
        _battery -= _batteryDrain;
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack
{
    private readonly int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        do
        {
            car.Drive();
        } while (car.BatteryDrained() is false && car.DistanceDriven() != _distance);

        return car.DistanceDriven() == _distance;
    }
}
