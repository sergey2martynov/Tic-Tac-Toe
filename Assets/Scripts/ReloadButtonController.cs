using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadButtonController : MonoBehaviour
{
    [SerializeField] private Button _button;

    [SerializeField] private GameObject _buttonGameObject;

    [SerializeField] private TextOutput _textOutput;

    private void Start()
    {
        _button.onClick.AddListener(OnButtonClicked);

        _buttonGameObject.SetActive(false);

        _textOutput.TextWasShown += ShowReloadButton;
    }

    private void OnButtonClicked()
    {
        SceneManager.LoadScene("scene1");
    }

    private void ShowReloadButton()
    {
        _buttonGameObject.SetActive(true);
    }
}