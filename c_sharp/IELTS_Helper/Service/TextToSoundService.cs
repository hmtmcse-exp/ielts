using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace IELTS_Helper.Service
{
    public class TextToSoundService
    {

        private SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public int Rate { set { speechSynthesizer.Rate = value; } }

        public TextToSoundService()
        {
            speechSynthesizer.SetOutputToDefaultAudioDevice();
        }

        public void Play(string text)
        {
            if(text != null)
            {
                speechSynthesizer.Speak(text);
            }
            else
            {
                speechSynthesizer.Speak("Empty Word.");
            }
        }


        public void PlayAsync(string text)
        {
            if (text != null)
            {
                speechSynthesizer.SpeakAsync(text);
            }
            else
            {
                speechSynthesizer.SpeakAsync("Empty Word.");
            }
        }

    }
}
