# WPF �A�j���[�V�����f���A�v���P�[�V����

���̃A�v���P�[�V�����́AWPF (Windows Presentation Foundation) ���g�p���č쐬���ꂽ�A�A�j���[�V�����L���ȃ��[�U�[�C���^�[�t�F�[�X�̃T���v���ł��B�����̃E�B���h�E�Ԃŉ�ʑJ�ڂ��s���A�e��ʂŗl�X�ȃA�j���[�V�������ʂ�̌��ł��܂��B

## �T�v

*   **�N�����**: �A�v���P�[�V�����N�����ɕ\�������V���v���ȃX�^�[�g��ʁB
*   **���[�h���**: �X�^�[�g��ʂ���J�ڂ��A�v���O���X�o�[�ƃA�j���[�V�����Ń��[�h������\�������ʁB
*   **���C�����**: ���[�h������ɕ\�������A�R���e���c���\������郁�C���A�v���P�[�V������ʁB
*   **�A�j���[�V����**: �t�F�[�h�C���E�t�F�[�h�A�E�g�A��]�A�_�ŁA�X���C�h�A�X�P�[���ȂǁAWPF�̃X�g�[���[�{�[�h�����p�����l�X�ȃA�j���[�V�������g�p���Ă��܂��B
*   **��ʑJ��**: �N���b�N�C�x���g���g���K�[�ɁA�E�B���h�E�ԂŃX���[�Y�ȉ�ʑJ�ڂ��s���܂��B

## ��ȋ@�\�ƃA�j���[�V����

���̃A�v���P�[�V�����́A�ȉ���3�̎�v�ȃE�B���h�E�ō\������Ă��܂��B

1.  **`MainWindow.xaml` (�X�^�[�g���)**
    *   �N�����Ƀt�F�[�h�C���A�j���[�V�����ŕ\������܂��B
    *   �u�J�n�v�{�^�����N���b�N����ƁA�t�F�[�h�A�E�g�A�j���[�V�����Ƌ��Ƀ��[�h��ʂ֑J�ڂ��܂��B

2.  **`LoadingWindow.xaml` (���[�h���)**
    *   �\�����Ƀt�F�[�h�C���A�j���[�V�����ŕ\������܂��B
    *   �ȉ��̃��[�h���A�j���[�V���������s����܂��B
        *   �X�s�i�[�̉�]�A�j���[�V���� (`SpinnerStoryboard`)
        *   "���[�f�B���O��..." �e�L�X�g�̓_�ŃA�j���[�V���� (`LoadingTextStoryboard`)
        *   �v���O���X�o�[�̐i�s�A�j���[�V���� (`ProgressStoryboard`)
    *   �v���O���X�o�[��100%�ɂȂ�ƁA�e�L�X�g�� "�����I�N���b�N���đ��s" �ɕς��܂��B
    *   ��ʂ��N���b�N����ƁA�t�F�[�h�A�E�g�A�j���[�V�����Ƌ��Ƀ��C����ʂ֑J�ڂ��܂��B

3.  **`MainAppWindow.xaml` (���C���A�v���P�[�V�������)**
    *   �\�����Ƀt�F�[�h�C���A�j���[�V�����ŕ\������܂��B
    *   �ȉ��̃R���e���c�\���A�j���[�V���������s����܂��B
        *   �T�C�h�p�l���̃X���C�h�A�j���[�V���� (`SlidePanelStoryboard`)
        *   ���C���R���e���c�G���A�̃X�P�[���A�j���[�V���� (`ContentScaleStoryboard`)
    *   �i�r�Q�[�V�����{�^����I���{�^�����z�u����Ă��܂��B

## ����̎d�g��

1.  �A�v���P�[�V�������N������ƁA`MainWindow` ���t�F�[�h�C�����܂��B
2.  `MainWindow` �́u�J�n�v�{�^�����N���b�N���܂��B
3.  `MainWindow` ���t�F�[�h�A�E�g���A`LoadingWindow` ���\������܂��B
4.  `LoadingWindow` ���t�F�[�h�C�����A�X�s�i�[�A���[�f�B���O�e�L�X�g�A�v���O���X�o�[�̃A�j���[�V�������J�n����܂��B
5.  �v���O���X�o�[����������ƁA`LoadingWindow` �̃e�L�X�g���ω����܂��B
6.  `LoadingWindow` ���N���b�N���܂��B
7.  `LoadingWindow` ���t�F�[�h�A�E�g���A`MainAppWindow` ���\������܂��B
8.  `MainAppWindow` ���t�F�[�h�C�����A�T�C�h�p�l���ƃR���e���c�G���A�̃A�j���[�V���������s����܂��B

## �Z�b�g�A�b�v�Ǝ��s

1.  ���̃v���W�F�N�g���N���[���܂��̓_�E�����[�h���܂��B
2.  Visual Studio �� `.sln` �t�@�C�����J���܂��B
3.  �\�����[�V�������r���h���܂� (�ʏ�� `Ctrl+Shift+B` �܂��� `F6`)�B
4.  �f�o�b�O�J�n (�ʏ�� `F5`) �܂��͎��s�t�@�C�� (`bin/Debug` �܂��� `bin/Release` �t�H���_���� `.exe` �t�@�C��) �����s���܂��B

## �J�X�^�}�C�Y�Ɗg�� (���S�Ҍ������)

���̃A�v���P�[�V�������x�[�X�ɁA�Ǝ��̋@�\��A�j���[�V������ǉ�������@���������Љ�܂��B

### 1. �V�����A�j���[�V������ǉ�����

WPF�̃A�j���[�V�����́A���XAML���� **Storyboard** ���g���Ē�`���܂��B

**�菇:**

1.  **Storyboard�̒�` (XAML):**
    �A�j���[�V������K�p�������E�B���h�E�܂��̓��[�U�[�R���g���[����XAML�t�@�C�����J���܂��B
    `<Window.Resources>` �� `<Grid.Resources>` �Ȃǂ̃��\�[�X�Z�N�V������ `<Storyboard>` ��ǉ����܂��B

    ```xml
    <Window.Resources>
        <Storyboard x:Key="MyNewAnimationStoryboard">
            <!-- ��: �{�^����1�b�����ē�������s�����ɂ���A�j���[�V���� -->
            <DoubleAnimation
                Storyboard.TargetName="MyButton"
                Storyboard.TargetProperty="Opacity"
                From="0.0" To="1.0" Duration="0:0:1" />
            <!-- ���̃A�j���[�V�������ǉ��\ -->
        </Storyboard>
    </Window.Resources>
    ```
    *   `x:Key`: Storyboard��C#�R�[�h����Q�Ƃ��邽�߂̖��O�ł��B
    *   `Storyboard.TargetName`: �A�j���[�V������K�p����UI�v�f�� `Name` �v���p�e�B���w�肵�܂��B
    *   `Storyboard.TargetProperty`: �A�j���[�V����������v���p�e�B (��: `Opacity`, `Width`, `(UIElement.RenderTransform).(ScaleTransform.ScaleX)`�Ȃ�) ���w�肵�܂��B
    *   `From`, `To`: �v���p�e�B�̊J�n�l�ƏI���l�B
    *   `Duration`: �A�j���[�V�����̌p�����ԁB

2.  **�A�j���[�V�����̊J�n (C#):**
    �R�[�h�r�n�C���h (��: `MyWindow.xaml.cs`) �ŁA��`����Storyboard���擾���ĊJ�n���܂��B

    ```csharp
    // MyWindow.xaml.cs
    private void StartMyAnimation()
    {
        var myAnimationStoryboard = (Storyboard)FindResource("MyNewAnimationStoryboard");
        if (myAnimationStoryboard != null)
        {
            myAnimationStoryboard.Begin(this); // this ��n�����ƂŁATargetName �����̃E�B���h�E���̗v�f���w���悤�ɂȂ�܂�
        }
    }

    // �Ⴆ�΁A�E�B���h�E�����[�h���ꂽ����{�^�����N���b�N���ꂽ���ɌĂяo��
    private void MyWindow_Loaded(object sender, RoutedEventArgs e)
    {
        StartMyAnimation();
    }
    ```

### 2. �V������� (�E�B���h�E) ��ǉ�����

�A�v���P�[�V�����ɐV������ʂ�ǉ�����̂͊ȒP�ł��B

**�菇:**

1.  **�V�����E�B���h�E�̍쐬:**
    *   Visual Studio�̃\�����[�V�����G�N�X�v���[���[�Ńv���W�F�N�g���E�N���b�N���܂��B
    *   �u�ǉ��v > �u�V�������ځv��I�����܂��B
    *   �uWPF�v�J�e�S������u�E�B���h�E (WPF)�v��I�����A���O��t���� (��: `NewScreenWindow.xaml`) �ǉ����܂��B

2.  **��ʑJ�ڂ̎���:**
    �����̃E�B���h�E����V�����E�B���h�E��\������ɂ́A�ȉ��̂悤�ɂ��܂��B

    ```csharp
    // ��: MainWindow.xaml.cs ���� NewScreenWindow ��\������
    private void ShowNewScreenButton_Click(object sender, RoutedEventArgs e)
    {
        var newScreenWindow = new NewScreenWindow();
        newScreenWindow.Show(); // �V�����E�B���h�E��\��

        // �K�v�ł���΁A���݂̃E�B���h�E�����
        // this.Close();
    }
    ```

### 3. UI�v�f�ɃC���^���N�V������ǉ�����

�{�^���N���b�N�Ȃǂ̃��[�U�[����ɉ����ď��������s������@�ł��B

**�菇:**

1.  **UI�v�f�̔z�u�ƃC�x���g�n���h���̐ݒ� (XAML):**
    XAML�Ń{�^���Ȃǂ̃R���g���[����z�u���A`Click` �Ȃǂ̃C�x���g�Ƀn���h�����\�b�h�����w�肵�܂��B

    ```xml
    <Button Content="���s" Name="MyActionButton" Click="MyActionButton_Click" />
    ```

2.  **�C�x���g�n���h���̎��� (C#):**
    �R�[�h�r�n�C���h�ŁA�w�肵�����O�̃��\�b�h���������܂��B

    ```csharp
    // MyWindow.xaml.cs
    private void MyActionButton_Click(object sender, RoutedEventArgs e)
    {
        // �{�^�����N���b�N���ꂽ���̏���
        MessageBox.Show("�A�N�V���������s����܂����I");

        // �����ő��̃��\�b�h���Ăяo������A�A�j���[�V�������J�n������ł��܂�
        // StartAnotherAnimation();
    }
    ```

## �܂Ƃ�

���̃A�v���P�[�V�����́AWPF�ɂ�����A�j���[�V�����Ɖ�ʑJ�ڂ̊�{�I�Ȏ����������Ă��܂��B��L�̊g�����@���Q�l�ɁA���ГƎ��̋@�\��ǉ�����WPF�J�����y����ł��������B
