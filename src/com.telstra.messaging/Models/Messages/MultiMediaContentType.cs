namespace com.telstra.messaging.Models.Messages
{
    public static class MultiMediaContentType
    {
        public const string AUDIO_AMR = "audio/amr";
        public const string AUDIO_MP3 = "audio/mp3";
        public const string AUDIO_MPEG3 = "audio/mpeg3";
        public const string AUDIO_MIDI = "audio/midi";
        public const string AUDIO_WAV = "audio/wav";
        public const string AUDIO_BASIC = "audio/basic";
        public const string IMAGE_GIF = "image/gif";
        public const string IMAGE_JPEG = "image/jpeg";
        public const string IMAGE_PNG = "image/png";
        public const string IMAGE_BMP = "image/bmp";
        public const string VIDEO_MPEG4 = "video/mpeg4";
        public const string VIDEO_MP4 = "video/mp4";
        public const string VIDEO_MPG = "video/mpg";
        public const string VIDEO_MPEG = "video/mpeg";
        public const string VIDEO_3GPP = "video/3gpp";
        public const string VIDEO_3GP = "video/3gp";

        public static List<string> ContentTypes = new List<string>() { AUDIO_AMR, AUDIO_MP3, AUDIO_MPEG3, AUDIO_MIDI, AUDIO_WAV, AUDIO_BASIC, IMAGE_GIF, IMAGE_JPEG, IMAGE_PNG, IMAGE_BMP, VIDEO_MPEG4, VIDEO_MP4, VIDEO_MPG, VIDEO_MPEG, VIDEO_3GPP, VIDEO_3GP };
    }
}