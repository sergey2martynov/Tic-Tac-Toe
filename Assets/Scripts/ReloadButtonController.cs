using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadButtonController : MonoBehaviour
{
    [SerializeField] private Button _button;
    
    [SerializeField] private GameObject _buttonGameObject;

    [SerializeField] private TextManager _textManager;

    private void Start()
    {
        _button.onClick.AddListener(OnButtonClicked);
        
        _buttonGameObject.SetActive(false);

        _textManager.GameOver += ShowReloadButton;
    }

    private void OnButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void ShowReloadButton()
    {
        _buttonGameObject.SetActive(true);
    }
}
