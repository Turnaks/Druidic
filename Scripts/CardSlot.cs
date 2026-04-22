using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class CardSlot : Node
{
	public Card _SlottedCard;

	public List<Aspect> _AspectWhiteList;

    public List<Aspect> _AspectGreyList;

    public List<Aspect> _AspectBlackList;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public bool IsAspectMatching(Card card)
    {
        foreach (Aspect aspect in _AspectBlackList)
        {
            if (card._Aspects.Contains(aspect))
                return false;
        }

        foreach (Aspect aspect in _AspectWhiteList)
        {
            if (!card._Aspects.Contains(aspect))
                return false;
        }
        
        return true;
    }
}
