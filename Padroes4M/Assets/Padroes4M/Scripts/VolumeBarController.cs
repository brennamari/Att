using UnityEngine;
using UnityEngine.UI;

public class VolumeBarController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    private void Start()
    {
        volumeSlider.onValueChanged.AddListener(ChangedVolume);
    }

    private void ChangedVolume(float sliderValue)
    {
        // envia o conteudo novo para o canal sobre o volume do youtue de audio
        AudioObserverManager.ChangedVolumesSliderValue(sliderValue);
        
    }
}
