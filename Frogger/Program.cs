using System;
using System.Speech.Synthesis;

namespace Frogger
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        private static SpeechSynthesizer synth = new SpeechSynthesizer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Speak("Welcome to Frogger!", VoiceGender.Male, 1, VoiceAge.Teen);
            using (var game = new Game1())
                game.Run();
            
        }

        public static void Speak(string message, VoiceGender gender, int rate, VoiceAge vAge)
        {
            synth.Rate = rate;
            synth.SelectVoiceByHints(gender);
            synth.Speak(message);
        }
    }
#endif
}
