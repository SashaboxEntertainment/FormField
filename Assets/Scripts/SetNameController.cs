using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetNameController : MonoBehaviour
{
    [SerializeField] private TMP_InputField _nickField;
    [SerializeField] private TMP_InputField _descriptionField;
    [SerializeField] private TMP_Dropdown _raceDropdown;
    [SerializeField] private TMP_Dropdown _classDropdown;

    [SerializeField] private TextMeshProUGUI _playerNick;
    [SerializeField] private TextMeshProUGUI _playerDescription;
    [SerializeField] private TextMeshProUGUI _playerRace;
    [SerializeField] private TextMeshProUGUI _playerClass;

    public void setName()
    {
        _playerNick.text = _nickField.text;
        _playerDescription.text = _descriptionField.text;

        _playerRace.text = _raceDropdown.options[_raceDropdown.value].text;
        _playerClass.text = _classDropdown.options[_classDropdown.value].text;
    }
}
