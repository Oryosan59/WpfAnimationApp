using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace WpfAnimationApp
{
    public partial class LoadingWindow : Window
    {
        private DispatcherTimer progressTimer;
        private bool isLoadingComplete = false;

        public LoadingWindow()
        {
            InitializeComponent();
            Loaded += LoadingWindow_Loaded;
        }

        private void LoadingWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // フェードインアニメーションを開始
            var fadeInStoryboard = (Storyboard)FindResource("FadeInStoryboard");
            fadeInStoryboard.Begin();

            // スピナーの回転アニメーションを開始
            var spinnerStoryboard = (Storyboard)FindResource("SpinnerStoryboard");
            spinnerStoryboard.Begin();

            // ローディングテキストの点滅アニメーションを開始
            var loadingTextStoryboard = (Storyboard)FindResource("LoadingTextStoryboard");
            loadingTextStoryboard.Begin();

            // プログレスバーのアニメーションを開始
            var progressStoryboard = (Storyboard)FindResource("ProgressStoryboard");
            progressStoryboard.Completed += (s, args) =>
            {
                isLoadingComplete = true;
                LoadingText.Text = "完了！クリックして続行";
            };
            progressStoryboard.Begin();

            // プログレスバーの値を監視してパーセンテージを更新
            StartProgressTimer();
        }

        private void StartProgressTimer()
        {
            progressTimer = new DispatcherTimer();
            progressTimer.Interval = TimeSpan.FromMilliseconds(50);
            progressTimer.Tick += (s, e) =>
            {
                PercentageText.Text = $"{(int)ProgressBar.Value}%";

                if (ProgressBar.Value >= 100)
                {
                    progressTimer.Stop();
                }
            };
            progressTimer.Start();
        }

        private void MainGrid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (isLoadingComplete)
            {
                TransitionToMainApp();
            }
        }

        private void TransitionToMainApp()
        {
            // フェードアウトアニメーションを開始
            var fadeOutStoryboard = (Storyboard)FindResource("FadeOutStoryboard");

            fadeOutStoryboard.Completed += (s, args) =>
            {
                // メイン画面を表示
                var mainAppWindow = new MainAppWindow();
                mainAppWindow.Show();

                // タイマーを停止
                progressTimer?.Stop();

                // 現在のウィンドウを閉じる
                this.Close();
            };

            fadeOutStoryboard.Begin();
        }
    }
}