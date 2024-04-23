using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletStartTransform : MonoBehaviour
{
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        
        cameraTransform = Camera.main.transform;
}

    // Update is called once per frame
    void Update()
    {
        // Obtener la rotaci�n de la c�mara
        Quaternion rotacionCamara = Camera.main.transform.rotation;

        // Asignar la rotaci�n al gameObject al que este script est� adjunto
        transform.rotation = rotacionCamara;
    }
}
