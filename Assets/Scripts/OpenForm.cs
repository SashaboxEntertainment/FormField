using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenForm : MonoBehaviour
{
    [SerializeField] private GameObject formPanel;
    [SerializeField] private GameObject nameController;

    private SetNameController setNameController;
    public static bool nowFilling = false;

    void Start()
    {
        setNameController = nameController.GetComponent<SetNameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (nowFilling)
            {
                Resume();
                setNameController.setName();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Pause();
        }
    }

    public void Resume()
    {
        formPanel.SetActive(false);
        Time.timeScale = 1f;
        nowFilling = false;
    }

    void Pause()
    {
        formPanel.SetActive(true);
        Time.timeScale = 0f;
        nowFilling = true;
    }
}
