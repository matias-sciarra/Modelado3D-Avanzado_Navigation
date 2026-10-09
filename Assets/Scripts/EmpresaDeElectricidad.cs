using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaDeElectricidad : MonoBehaviour
{
    public Domicilio[] domicilios;

    // Start is called before the first frame update
    void Start()
{
    domicilios = FindObjectsOfType<Domicilio>();

    for (int i = 0; i < domicilios.Length; i++)
    {
        // Asignar electricidad aleatoriamente
        

        foreach (Domicilio domicilio in domicilios)
        {
            domicilio.servicioElectricoActivo = Random.value > 0.5f;
            domicilio.luzDomicilio.SetActive(domicilio.servicioElectricoActivo);
        }
        
    }

    MostrarInfoEnConsola();
}

    // Update is called once per frame
    void Update()
    {
        //Tecla C (CORTE): apaga todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.C))
        {
        }
        //Tecla R(RESTITUCION): enciende las luces solo de los domicilios 
        // con servicioElectricoActivo verdadero
        if (Input.GetKeyDown(KeyCode.R))
        {
        }
        //Tecla T(TODOS): enciende todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.T))
        {
        }
    }

    void MostrarInfoEnConsola()
    {
        //cuántos domicilios tienen su servicio eléctrico activo
        // porcentaje de domicilios con servicio eléctrico activo
    }
}
