using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    Defender defender;

    void OnMouseDown()
    {
        AttemptToPlaceDefnederAt(SnapToGrid(GetSqaureClicked()));
        // Debug.Log(this.gameObject.name + "Collider Clicked" + Input.mousePosition.x + ", " + Input.mousePosition.y);
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {

        defender = defenderToSelect;

    }

    private void AttemptToPlaceDefnederAt(Vector2 gridPos)
    {

        var StarDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();
        //star가 충분하다면 
            //defender 소환
            //star 소비
        if(StarDisplay.HaveEnoughStars(defenderCost))
        {

            SpawnDefender(gridPos);
            StarDisplay.SpendStars(defenderCost);

        }

    }



    private Vector2 GetSqaureClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }


    private void SpawnDefender(Vector2 pos)
    {
        Defender newDefender = Instantiate(defender, pos, Quaternion.identity) as Defender;
    }

}
