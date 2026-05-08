namespace Practika11
{
    interface IStorable
    {
        void SaveToFile(string filePath);
        void LoadFromFile(string filePath);
    }
}
