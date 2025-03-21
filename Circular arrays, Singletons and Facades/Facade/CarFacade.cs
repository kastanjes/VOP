namespace Facade;

public class CarFacade
{
    private Brakes brakes = new Brakes();
    private Engine engine = new Engine();
    private Steering steering = new Steering();
    
    public void Start() /*Starts the car (start engine).*/
    {
        engine.Start();
    }

    public void Stop() /*Stops the car (decelerate engine, apply brakes and stop engine).*/
    {
        engine.Start();
    }

    public void Brake() /*Applies the brak */
    {
        brakes.Apply();
    }

    public void Accelerate() /*Accelerates the engine (increase engine throttle).*/
    {
        engine.Accelerate();
    }

    public void Decelerate() /*Decelerates the engine(decrease engine throttle)*/
    {
        engine.Decelerate();
    }

    public void Steer() /*Steers the car in the given direction (left or right).*/
    {
        steering.TurnLeft();
        steering.TurnRight();
    }
}