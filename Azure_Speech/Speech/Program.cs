using System;

using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
namespace HelloWorld
{
    class Program
    {   //Accesamos a los servicios con una función Async
        static async Task Main()
        {
            await RecognizeSpeechAsync();
        }

        static async Task RecognizeSpeechAsync(){
            //Configuramos la información para accesar a los servicios
            // Podermos usar la Clave 1 o Clave 2 que hemos creado con Speech, REGION
            var config = SpeechConfig.FromSubscription("0345d002e03145a6a49e76a03d3f1c26","eastus");
            //Agregamos el archivo de audio
            using (var audioInput = AudioConfig.FromWavFileInput("narration.wav"))
            //Pasamos los parámetros requeridos para el Servicio Speech
            // y el archivo de audio que quieres transcribit
            using (var recognizer = new SpeechRecognizer(config, audioInput)){
                Console.WriteLine("Recongnizing first result...");
                var result = await recognizer.RecognizeOnceAsync();
                switch (result.Reason)
                {
                    case ResultReason.RecognizedSpeech:
                        //El archivo de audio es reconocido y print en terminal
                        Console.WriteLine($"He reconocido: {result.Text}");
                    break;

                    case ResultReason.NoMatch:
                        //Cuando no se puede reconocer el audio
                        //Saluda del mensaje con el error
                        Console.WriteLine($"NOMATCH: No he podido reconocer el audio");
                    break;

                    case ResultReason.Canceled:
                        //Se cancela todo
                        //Mostramos el porqué
                        var cancellation = CancellationDetails.FromResult(result);
                        Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");
                        if(cancellation.Reason == CancellationReason.Error)
                        {
                            Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                            Console.WriteLine($"CANCELED: ErrorDetails={cancellation.ErrorDetails}");
                        }
                    break; 
                    
                }
            }

        }
    }
}
