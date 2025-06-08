# WPF アニメーションデモアプリケーション

このアプリケーションは、WPF (Windows Presentation Foundation) を使用して作成された、アニメーション豊かなユーザーインターフェースのサンプルです。複数のウィンドウ間で画面遷移を行い、各画面で様々なアニメーション効果を体験できます。

## 概要

*   **起動画面**: アプリケーション起動時に表示されるシンプルなスタート画面。
*   **ロード画面**: スタート画面から遷移し、プログレスバーとアニメーションでロード処理を表現する画面。
*   **メイン画面**: ロード完了後に表示される、コンテンツが表示されるメインアプリケーション画面。
*   **アニメーション**: フェードイン・フェードアウト、回転、点滅、スライド、スケールなど、WPFのストーリーボードを活用した様々なアニメーションを使用しています。
*   **画面遷移**: クリックイベントをトリガーに、ウィンドウ間でスムーズな画面遷移を行います。

## 主な機能とアニメーション

このアプリケーションは、以下の3つの主要なウィンドウで構成されています。

1.  **`MainWindow.xaml` (スタート画面)**
    *   起動時にフェードインアニメーションで表示されます。
    *   「開始」ボタンをクリックすると、フェードアウトアニメーションと共にロード画面へ遷移します。

2.  **`LoadingWindow.xaml` (ロード画面)**
    *   表示時にフェードインアニメーションで表示されます。
    *   以下のロード中アニメーションが実行されます。
        *   スピナーの回転アニメーション (`SpinnerStoryboard`)
        *   "ローディング中..." テキストの点滅アニメーション (`LoadingTextStoryboard`)
        *   プログレスバーの進行アニメーション (`ProgressStoryboard`)
    *   プログレスバーが100%になると、テキストが "完了！クリックして続行" に変わります。
    *   画面をクリックすると、フェードアウトアニメーションと共にメイン画面へ遷移します。

3.  **`MainAppWindow.xaml` (メインアプリケーション画面)**
    *   表示時にフェードインアニメーションで表示されます。
    *   以下のコンテンツ表示アニメーションが実行されます。
        *   サイドパネルのスライドアニメーション (`SlidePanelStoryboard`)
        *   メインコンテンツエリアのスケールアニメーション (`ContentScaleStoryboard`)
    *   ナビゲーションボタンや終了ボタンが配置されています。

## 動作の仕組み

1.  アプリケーションを起動すると、`MainWindow` がフェードインします。
2.  `MainWindow` の「開始」ボタンをクリックします。
3.  `MainWindow` がフェードアウトし、`LoadingWindow` が表示されます。
4.  `LoadingWindow` がフェードインし、スピナー、ローディングテキスト、プログレスバーのアニメーションが開始されます。
5.  プログレスバーが完了すると、`LoadingWindow` のテキストが変化します。
6.  `LoadingWindow` をクリックします。
7.  `LoadingWindow` がフェードアウトし、`MainAppWindow` が表示されます。
8.  `MainAppWindow` がフェードインし、サイドパネルとコンテンツエリアのアニメーションが実行されます。

## セットアップと実行

1.  このプロジェクトをクローンまたはダウンロードします。
2.  Visual Studio で `.sln` ファイルを開きます。
3.  ソリューションをビルドします (通常は `Ctrl+Shift+B` または `F6`)。
4.  デバッグ開始 (通常は `F5`) または実行ファイル (`bin/Debug` または `bin/Release` フォルダ内の `.exe` ファイル) を実行します。

## カスタマイズと拡張 (初心者向け解説)

このアプリケーションをベースに、独自の機能やアニメーションを追加する方法をいくつか紹介します。

### 1. 新しいアニメーションを追加する

WPFのアニメーションは、主にXAML内の **Storyboard** を使って定義します。

**手順:**

1.  **Storyboardの定義 (XAML):**
    アニメーションを適用したいウィンドウまたはユーザーコントロールのXAMLファイルを開きます。
    `<Window.Resources>` や `<Grid.Resources>` などのリソースセクションに `<Storyboard>` を追加します。

    ```xml
    <Window.Resources>
        <Storyboard x:Key="MyNewAnimationStoryboard">
            <!-- 例: ボタンを1秒かけて透明から不透明にするアニメーション -->
            <DoubleAnimation
                Storyboard.TargetName="MyButton"
                Storyboard.TargetProperty="Opacity"
                From="0.0" To="1.0" Duration="0:0:1" />
            <!-- 他のアニメーションも追加可能 -->
        </Storyboard>
    </Window.Resources>
    ```
    *   `x:Key`: StoryboardをC#コードから参照するための名前です。
    *   `Storyboard.TargetName`: アニメーションを適用するUI要素の `Name` プロパティを指定します。
    *   `Storyboard.TargetProperty`: アニメーションさせるプロパティ (例: `Opacity`, `Width`, `(UIElement.RenderTransform).(ScaleTransform.ScaleX)`など) を指定します。
    *   `From`, `To`: プロパティの開始値と終了値。
    *   `Duration`: アニメーションの継続時間。

2.  **アニメーションの開始 (C#):**
    コードビハインド (例: `MyWindow.xaml.cs`) で、定義したStoryboardを取得して開始します。

    ```csharp
    // MyWindow.xaml.cs
    private void StartMyAnimation()
    {
        var myAnimationStoryboard = (Storyboard)FindResource("MyNewAnimationStoryboard");
        if (myAnimationStoryboard != null)
        {
            myAnimationStoryboard.Begin(this); // this を渡すことで、TargetName がこのウィンドウ内の要素を指すようになります
        }
    }

    // 例えば、ウィンドウがロードされた時やボタンがクリックされた時に呼び出す
    private void MyWindow_Loaded(object sender, RoutedEventArgs e)
    {
        StartMyAnimation();
    }
    ```

### 2. 新しい画面 (ウィンドウ) を追加する

アプリケーションに新しい画面を追加するのは簡単です。

**手順:**

1.  **新しいウィンドウの作成:**
    *   Visual Studioのソリューションエクスプローラーでプロジェクトを右クリックします。
    *   「追加」 > 「新しい項目」を選択します。
    *   「WPF」カテゴリから「ウィンドウ (WPF)」を選択し、名前を付けて (例: `NewScreenWindow.xaml`) 追加します。

2.  **画面遷移の実装:**
    既存のウィンドウから新しいウィンドウを表示するには、以下のようにします。

    ```csharp
    // 例: MainWindow.xaml.cs から NewScreenWindow を表示する
    private void ShowNewScreenButton_Click(object sender, RoutedEventArgs e)
    {
        var newScreenWindow = new NewScreenWindow();
        newScreenWindow.Show(); // 新しいウィンドウを表示

        // 必要であれば、現在のウィンドウを閉じる
        // this.Close();
    }
    ```

### 3. UI要素にインタラクションを追加する

ボタンクリックなどのユーザー操作に応じて処理を実行する方法です。

**手順:**

1.  **UI要素の配置とイベントハンドラの設定 (XAML):**
    XAMLでボタンなどのコントロールを配置し、`Click` などのイベントにハンドラメソッド名を指定します。

    ```xml
    <Button Content="実行" Name="MyActionButton" Click="MyActionButton_Click" />
    ```

2.  **イベントハンドラの実装 (C#):**
    コードビハインドで、指定した名前のメソッドを実装します。

    ```csharp
    // MyWindow.xaml.cs
    private void MyActionButton_Click(object sender, RoutedEventArgs e)
    {
        // ボタンがクリックされた時の処理
        MessageBox.Show("アクションが実行されました！");

        // ここで他のメソッドを呼び出したり、アニメーションを開始したりできます
        // StartAnotherAnimation();
    }
    ```

## まとめ

このアプリケーションは、WPFにおけるアニメーションと画面遷移の基本的な実装を示しています。上記の拡張方法を参考に、ぜひ独自の機能を追加してWPF開発を楽しんでください。
