using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject puntuacionUI;
    [SerializeField]
    private GameObject recordUI;

    [SerializeField]
    private GameObject panelDerrota;
    private int puntuacion;
    private int record;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntuacion = 0;
        record = 0;
        ActualizarPuntuacionUI(puntuacion);
        ActualizarRecordUI(record);

        if (PlayerPrefs.HasKey("RECORD")) {
            record = PlayerPrefs.GetInt("RECORD");
            ActualizarRecordUI(record);
        } else {
            PlayerPrefs.SetInt("RECORD", 0);
            record = PlayerPrefs.GetInt("RECORD");
            ActualizarRecordUI(record);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActualizarPuntuacion(int incremento) {
        puntuacion = puntuacion + incremento;
        ActualizarPuntuacionUI(puntuacion);

        record = PlayerPrefs.GetInt("RECORD");

        if (puntuacion > record) {
            PlayerPrefs.SetInt("RECORD", puntuacion);
            record = PlayerPrefs.GetInt("RECORD");
            ActualizarRecordUI(record);
        }
    }

    public void MostrarPanelDerrota() {
        panelDerrota.gameObject.SetActive(true);
        Invoke("DetenerJuego", 1.0f);
    }
    public void DetenerJuego() {
        Time.timeScale = 0.0f;
    }

    public void ActualizarPuntuacionUI(int puntos) {
        puntuacionUI.gameObject.GetComponent<TMP_Text>().text = puntos.ToString();
    }
    public void ActualizarRecordUI(int puntosRecord) {
        recordUI.gameObject.GetComponent<TMP_Text>().text = puntosRecord.ToString();
    }
    public void Reiniciar() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Juego");
    }
}
