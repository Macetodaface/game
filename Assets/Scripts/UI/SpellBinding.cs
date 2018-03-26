﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpellBinding
{
    public GameController gameController =
        GameObject.Find("GameController").GetComponent<GameController>();
    public Spell spell;
    private KeyCode key;
    private Text textBox;

	public SpellBinding(Spell spell, KeyCode key, Text textBox) {
        this.spell = spell;
        this.key = key;
        this.textBox = textBox;
	}

    public void Update()
    {
        UpdateTextBox();
    }

    public void UpdateTextBox()
    {
        this.textBox.text = Utils.ToDisplayText(spell.GetCooldown());
    }


    public KeyCode GetKey()
    {
        return key;
    }

}