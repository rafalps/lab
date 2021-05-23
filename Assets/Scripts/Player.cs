using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8.0f;
    public CharacterController controller;

	public bool travarMouse = true; //Controla se o cursor do mouse é exibido
	public float sensibilidade = 2.0f; //Controla a sensibilidade do mouse
	private float mouseX = 0.0f, mouseY = 0.0f; //Variáveis que controla a rotação do mouse

    void Start()
    {
        // if (!travarMouse) { return; }
		// Cursor.visible = false;
		// Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        // float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        // Vector3 mov = new Vector3(horizontal, 0, vertical);
        // controller.Move(mov);

        // mouseX += Input.GetAxis("Mouse X") * sensibilidade; // Incrementa o valor do eixo X e multiplica pela sensibilidade
		// mouseY -= Input.GetAxis("Mouse Y") * sensibilidade; // Incrementa o valor do eixo Y e multiplica pela sensibilidade. (Obs. usamos o - para inverter os valores)
		// transform.eulerAngles = new Vector3(mouseY, mouseX, 0); //Executa a rotação da câmera de acordo com os eixos
    }
}
