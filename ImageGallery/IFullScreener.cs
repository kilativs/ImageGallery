namespace ImageGallery
{
    public interface IFullScreener
    {
        byte[] ImageData { set; }
        string Title { set; }
        void ShowModal();
    }
}