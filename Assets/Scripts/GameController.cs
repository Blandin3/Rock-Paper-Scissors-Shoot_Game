using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public enum Choice { None, Rock, Paper, Scissors }

    private Choice playerChoice = Choice.None;
    private Choice computerChoice = Choice.None;

    private bool hasShot = false;   // ✅ Anti-cheat lock

    public TextMeshProUGUI playerText;
    public TextMeshProUGUI computerText;
    public TextMeshProUGUI resultText;

    public GameObject replayButton;

    // ✅ PLAYER SELECTION (LOCKED AFTER SHOOT)

    public void SelectRock()
    {
        if (hasShot) return;

        playerChoice = Choice.Rock;
        UpdatePlayerUI();
    }

    public void SelectPaper()
    {
        if (hasShot) return;

        playerChoice = Choice.Paper;
        UpdatePlayerUI();
    }

    public void SelectScissors()
    {
        if (hasShot) return;

        playerChoice = Choice.Scissors;
        UpdatePlayerUI();
    }

    void UpdatePlayerUI()
    {
        playerText.text = "Player: " + playerChoice;
    }

    // ✅ SHOOT LOGIC

    public void Shoot()
    {
        if (playerChoice == Choice.None)
        {
            resultText.text = "Select a choice first!";
            return;
        }

        hasShot = true;   // ✅ LOCK SELECTION

        computerChoice = (Choice)Random.Range(1, 4);

        computerText.text = "Computer: " + computerChoice;

        DecideWinner();

        replayButton.SetActive(true);
    }

    // ✅ WINNER LOGIC (ENUM + RULES)

    void DecideWinner()
    {
        if (playerChoice == computerChoice)
        {
            resultText.text = "Draw!";
        }
        else if (
            (playerChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
            (playerChoice == Choice.Scissors && computerChoice == Choice.Paper) ||
            (playerChoice == Choice.Paper && computerChoice == Choice.Rock)
        )
        {
            resultText.text = "Player Wins!";
        }
        else
        {
            resultText.text = "Computer Wins!";
        }
    }

    // ✅ REPLAY / RESET LOGIC

    public void Replay()
    {
        hasShot = false;   // ✅ UNLOCK SELECTION

        playerChoice = Choice.None;
        computerChoice = Choice.None;

        playerText.text = "Player:";
        computerText.text = "Computer:";
        resultText.text = "";

        replayButton.SetActive(false);
    }
}


