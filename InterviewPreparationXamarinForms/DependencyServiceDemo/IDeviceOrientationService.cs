namespace InterviewPreparationXamarinForms.DependencyServiceDemo
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }

    public enum DeviceOrientation
    {
        Undefined,
        Landscape,
        Portrait
    }
}
