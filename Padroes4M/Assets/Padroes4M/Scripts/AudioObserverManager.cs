using System;

// youtube do audio
public class AudioObserverManager 
{
    // criar o ponto que permite aos interessados se inscreverem 
    // no canal

    public static Action<float> OnVolumesSliderValueChanged;
    
    // permite que o criador do conteudo do valor do slider manda
    // os dados

    public static void ChangedVolumesSliderValue(float sliderValue)
    {
        // tem algum inscrito? se tiver mande as notificções
        OnVolumesSliderValueChanged?.Invoke(sliderValue);
    }

}
