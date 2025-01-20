using System;
using System.Windows.Forms;

namespace KursovoyProject
{
    public partial class Form1 : Form
    {
        private int playerScore;
        private int dealerScore;
        private Random random;
        private int bet;

        public Form1()
        {
            InitializeComponent();
            random = new Random(); // ������������� Random
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // �������� ���� � ������
            ResetGame();
            bet = 0; // �������� ������
            numericUpDownBet.Value = 0; // �������� �������� NumericUpDown
            lblBet.Text = $"������: {bet}"; // �������� ����������� ������
            lblResult.Text = string.Empty; // �������� ���������
            lblDealerScore.Text = "���� ������: 0"; // �������� ���� ������
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            int card = DrawCard();
            playerScore += card;
            UpdateScoreDisplay();

            if (playerScore > 21)
            {
                MessageBox.Show("�� ���������! ���� ����: " + playerScore);
                ResetGame();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            // ����� ����� �����
            dealerScore = DrawCard() + DrawCard(); // ����� ����� 2 �����
            lblDealerScore.Text = $"���� ������: {dealerScore}"; // �������� ����������� ����� ������

            while (dealerScore < 17) // ����� ����� �����, ���� ����� ������ 17
            {
                dealerScore += DrawCard();
            }

            lblDealerScore.Text = $"���� ������: {dealerScore}"; // �������� ����������� ����� ������

            // ����������� ����������
            if (dealerScore > 21 || playerScore > dealerScore)
            {
                MessageBox.Show("�� ������!!! ���� ����: " + playerScore);
            }
            else if (playerScore < dealerScore)
            {
                MessageBox.Show("�� �� � ���... ���� ����: " + playerScore);
            }
            else
            {
                MessageBox.Show("�����! ���� ����: " + playerScore);
            }

            ResetGame();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            // ������� ����
            string rules = "������� ���� � ��������:\n\n" +
                           "1. ���� ���� - ������� 21 ���� ��� ������� � ����� ��������, �� �������� ���.\n" +
                           "2. ����� � ����� �������� �� ��� �����. ����� ����� ���� ����� � ���� ����� ������.\n" +
                           "3. ����� ����� ������� 'Hit' (����� �����) ��� 'Stand' (������������).\n" +
                           "4. ���� ����� ����� ������ ��������� 21, �� �����������.\n" +
                           "5. ����� ����� �����, ���� ����� ��� ����� ������ 17.\n" +
                           "6. ���� ����� ��������� 21, ����� ����������.\n" +
                           "7. ���� ����� ����� ������ �����, ��� �����, �� ����������.\n" +
                           "8. ���� � ������ � ������ ���������� ���������� �����, ��� �����.\n";

            MessageBox.Show(rules, "������� ����");
        }

        private int DrawCard()
        {
            return random.Next(1, 11); // ���������� �������� ����� �� 1 �� 10
        }

        private void UpdateScoreDisplay()
        {
            lblScore.Text = $"���� ����: {playerScore}. ������: {bet}";

            if (playerScore > 21)
            {
                lblResult.Text = "�������!";
            }
            else
            {
                lblResult.Text = string.Empty;
            }
        }

        private void ResetGame()
        {
            playerScore = 0;
            dealerScore = 0;
            UpdateScoreDisplay();
            lblDealerScore.Text = "���� ������: 0"; // �������� ���� ������
        }

        private void numericUpDownBet_ValueChanged(object sender, EventArgs e)
        {
            bet = (int)numericUpDownBet.Value;
            lblBet.Text = $"������: {bet}";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            // ���� ����� ����� �������� ������ ��� �������, ���� �� �� �����
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            // ���� ����� ����� �������� ������ ��� �������, ���� �� �� �����
        }
    }
}