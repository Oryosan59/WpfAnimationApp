using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WpfAnimationApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 画面が読み込まれたらフェードインアニメーションを開始
            var fadeInStoryboard = (Storyboard)FindResource("FadeInStoryboard");
            fadeInStoryboard.Begin();

            //// タイトルのスケールアニメーションも同時に開始
            //var titleScaleStoryboard = (Storyboard)FindResource("TitleScaleStoryboard");
            //titleScaleStoryboard.Begin();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // フェードアウトアニメーションを開始
            var fadeOutStoryboard = (Storyboard)FindResource("FadeOutStoryboard");

            // アニメーション完了時のイベントハンドラを設定
            fadeOutStoryboard.Completed += (s, args) =>
            {
                // ロード画面を表示
                var loadingWindow = new LoadingWindow();
                loadingWindow.Show();

                // 現在のウィンドウを閉じる
                this.Close();
            };

            fadeOutStoryboard.Begin();
        }
    }
}