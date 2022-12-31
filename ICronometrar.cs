namespace CronometroSolid
{
    public interface ICronometrar
    {
        string ValueCrono { get; }
        void Start();
        void Pause();
        void Stop();
        void AddSecond();
    }
}
