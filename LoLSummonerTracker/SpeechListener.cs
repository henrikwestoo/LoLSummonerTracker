using System;
using System.Speech.Recognition;

namespace LoLSummonerTracker
{
    public class SpeechListener
    {

        GUI gui;

        public SpeechListener(GUI gui) { this.gui = gui; }

        public void StartListening() {

            gui.setLabel("speech activated");

            // Create an in-process speech recognizer for the en-US locale.  
            using (
            SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
                new System.Globalization.CultureInfo("en-US")))
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();
                
                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                
            }


        }

        // Handle the SpeechRecognized event.  
        public void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string hej = "hej";
            string hej2 = "2hej";

            gui.setLabel("Recognized text: " + e.Result.Text);
        }

    }
}
