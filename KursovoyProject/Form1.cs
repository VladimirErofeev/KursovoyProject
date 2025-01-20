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
            random = new Random(); // Инициализация Random
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Сбросить очки и ставку
            ResetGame();
            bet = 0; // Сбросить ставку
            numericUpDownBet.Value = 0; // Сбросить значение NumericUpDown
            lblBet.Text = $"Ставка: {bet}"; // Обновить отображение ставки
            lblResult.Text = string.Empty; // Очистить результат
            lblDealerScore.Text = "Очки дилера: 0"; // Сбросить очки дилера
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            int card = DrawCard();
            playerScore += card;
            UpdateScoreDisplay();

            if (playerScore > 21)
            {
                MessageBox.Show("Вы проиграли! Ваши очки: " + playerScore);
                ResetGame();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            // Дилер берет карты
            dealerScore = DrawCard() + DrawCard(); // Дилер берет 2 карты
            lblDealerScore.Text = $"Очки дилера: {dealerScore}"; // Обновить отображение очков дилера

            while (dealerScore < 17) // Дилер берет карты, пока сумма меньше 17
            {
                dealerScore += DrawCard();
            }

            lblDealerScore.Text = $"Очки дилера: {dealerScore}"; // Обновить отображение очков дилера

            // Определение победителя
            if (dealerScore > 21 || playerScore > dealerScore)
            {
                MessageBox.Show("АЙ ТИИИГР!!! Ваши очки: " + playerScore);
            }
            else if (playerScore < dealerScore)
            {
                MessageBox.Show("Ну ты и нуб... Ваши очки: " + playerScore);
            }
            else
            {
                MessageBox.Show("Ничья! Ваши очки: " + playerScore);
            }

            ResetGame();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            // Правила игры
            string rules = "Правила игры в блэкджек:\n\n" +
                           "1. Цель игры - набрать 21 очко или близкое к этому значение, не превышая его.\n" +
                           "2. Игрок и дилер получают по две карты. Игрок видит свои карты и одну карту дилера.\n" +
                           "3. Игрок может выбрать 'Hit' (взять карту) или 'Stand' (остановиться).\n" +
                           "4. Если сумма очков игрока превышает 21, он проигрывает.\n" +
                           "5. Дилер берет карты, пока сумма его очков меньше 17.\n" +
                           "6. Если дилер превышает 21, игрок выигрывает.\n" +
                           "7. Если игрок имеет больше очков, чем дилер, он выигрывает.\n" +
                           "8. Если у игрока и дилера одинаковое количество очков, это ничья.\n";

            MessageBox.Show(rules, "Правила игры");
        }

        private int DrawCard()
        {
            return random.Next(1, 11); // Возвращает значение карты от 1 до 10
        }

        private void UpdateScoreDisplay()
        {
            lblScore.Text = $"Ваши очки: {playerScore}. Ставка: {bet}";

            if (playerScore > 21)
            {
                lblResult.Text = "Перебор!";
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
            lblDealerScore.Text = "Очки дилера: 0"; // Сбросить очки дилера
        }

        private void numericUpDownBet_ValueChanged(object sender, EventArgs e)
        {
            bet = (int)numericUpDownBet.Value;
            lblBet.Text = $"Ставка: {bet}";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            // Этот метод можно оставить пустым или удалить, если он не нужен
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            // Этот метод можно оставить пустым или удалить, если он не нужен
        }
    }
}