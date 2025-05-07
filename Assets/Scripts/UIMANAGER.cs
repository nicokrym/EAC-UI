using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TMP_InputField inputA;
    public TMP_InputField inputB;
    public TextMeshProUGUI txtRespuesta;
    int respuesta;
    int numeroA;
    int numeroB;

    // Start is called before the first frame update
    void Start()
    {
        txtRespuesta.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void apretarBoton()
    {
        numeroA =

        respuesta = numeroA + numeroB;
        txtRespuesta.text = "La suma entre " + inputA + " y " + inputB + " da como resultado " + respuesta;
    }
}
