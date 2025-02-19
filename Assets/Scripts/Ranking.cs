using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private Dictionary<string, int> playerScores = new Dictionary<string, int>();

    // Add a score for a player
    public void AddScore(string playerName, int score)
    {
        if (playerScores.ContainsKey(playerName))
        {
            playerScores[playerName] += score;
        }
        else
        {
            playerScores[playerName] = score;
        }
    }

    // Get the score of a player
    public int GetScore(string playerName)
    {
        if (playerScores.ContainsKey(playerName))
        {
            return playerScores[playerName];
        }
        return 0;
    }

    // Get the ranking of all players
    public List<KeyValuePair<string, int>> GetRanking()
    {
        List<KeyValuePair<string, int>> ranking = new List<KeyValuePair<string, int>>(playerScores);
        ranking.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        return ranking;
    }
}