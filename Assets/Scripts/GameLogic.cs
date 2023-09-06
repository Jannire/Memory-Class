using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeCard
{
    public string name;
    public bool isShown;

    public PokeCard(string name)
    {
        this.name = name;
        this.isShown = false;
    }
}

public class GameLogic : MonoBehaviour
{
    private List<PokeCard> pokeCardList;
    private PokeCard selected;
    private CardLogic card1;
    private CardLogic card2;


    private void Start()
    {
        pokeCardList = new List<PokeCard>();
        PokeCard poke1 = new PokeCard("snorlax");
        PokeCard poke2 = new PokeCard("jigglypuff");
        PokeCard poke3 = new PokeCard("squirtle");
        PokeCard poke4 = new PokeCard("bulbasur");
        PokeCard poke5 = new PokeCard("pidgey");
        PokeCard poke6 = new PokeCard("psyduck");
        PokeCard poke7 = new PokeCard("charmander");
        PokeCard poke8 = new PokeCard("bulbasur");
        PokeCard poke9 = new PokeCard("pikachu");
        PokeCard poke10 = new PokeCard("pikachu");
        PokeCard poke11 = new PokeCard("snorlax");
        PokeCard poke12 = new PokeCard("pidgey");
        PokeCard poke13 = new PokeCard("squirtle");
        PokeCard poke14 = new PokeCard("psyduck");
        PokeCard poke15 = new PokeCard("charmander");
        PokeCard poke16 = new PokeCard("jigglypuff");

        pokeCardList.Add(poke1);
        pokeCardList.Add(poke2);
        pokeCardList.Add(poke3);
        pokeCardList.Add(poke4);
        pokeCardList.Add(poke5);
        pokeCardList.Add(poke6);
        pokeCardList.Add(poke7);
        pokeCardList.Add(poke8);
        pokeCardList.Add(poke9);
        pokeCardList.Add(poke10);
        pokeCardList.Add(poke11);
        pokeCardList.Add(poke12);
        pokeCardList.Add(poke13);
        pokeCardList.Add(poke14);
        pokeCardList.Add(poke15);
        pokeCardList.Add(poke16);
    }

    public void PlayCard(int pos, CardLogic card)
    {
        if (selected == null)
        {
            selected = pokeCardList[pos];
            card1 = card;
        }
        else
        {
            card2 = card;
            PokeCard secondCard = pokeCardList[pos];
            if (selected.name == secondCard.name)
            {
                selected.isShown = true;
                secondCard.isShown = true;
            }
            else
            {
                Invoke("ClosedCards", 2f);

            }
            selected = null;
        }

    }
    public void ClosedCards()
    {
        card1.ClosedCard();
        card2.ClosedCard();
    }
}
