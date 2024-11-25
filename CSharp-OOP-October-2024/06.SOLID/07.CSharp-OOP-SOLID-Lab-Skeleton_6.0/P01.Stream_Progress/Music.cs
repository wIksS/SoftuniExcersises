namespace P01.Stream_Progress
{
    public class Music : Streamable
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int bytesSent) : base(length, bytesSent)
        {
            this.artist = artist;
            this.album = album;
        }
    }
}
