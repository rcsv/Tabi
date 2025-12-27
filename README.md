# Tabi — Rustで作るデスクトップアプリ

概要
- Rustでクロスプラットフォームなデスクトップアプリを作るためのテンプレート兼ガイド。
- 軽量で安全なバックエンドをRustで、UIはネイティブまたはシンプルなレンダリングで実装。

必須環境
- Rust（rustupでstableツールチェーンを推奨）
- ビルドツール（各プラットフォームのビルド用ツールチェーン）
- フレームワークに応じてNode/npmやネイティブライブラリが必要になる場合あり

よく使われるフレームワーク（選択例）
- Tauri — Webフロントエンド + Rustバックエンド、軽量バンドル
- Iced — 純Rustで宣言的なGUI（クロスプラットフォーム）
- Druid — ネイティブ寄りのUIライブラリ
- GTK-rs — GTKベースのネイティブUI（Linux/Windows/macOSに対応）

クイックスタート（Icedの最小例）
- プロジェクト作成
```bash
cargo new --bin my_app
cd my_app
# Cargo.toml に iced を追加（例: iced = "0.9"）
```
- src/main.rs の最小例
```rust
use iced::{Settings, Application};

fn main() -> iced::Result {
    MyApp::run(Settings::default())
}

struct MyApp;
impl Application for MyApp {
    type Executor = iced::executor::Default;
    type Message = ();
    type Flags = ();

    fn new(_flags: ()) -> (Self, iced::Command<Self::Message>) { (Self, iced::Command::none()) }
    fn title(&self) -> String { "Tabi".into() }
    fn update(&mut self, _msg: Self::Message) -> iced::Command<Self::Message> { iced::Command::none() }
    fn view(&self) -> iced::Element<'_, Self::Message> {
        use iced::{Text, Column, Element};
        Column::new().push(Text::new("Hello, Tabi!")).into()
    }
}
```
- 実行
```bash
cargo run
```

ビルドと配布
- 開発ビルド: cargo build
- リリースビルド: cargo build --release
- 配布: Tauriなら tauri build、ネイティブなら cargo-bundle / cargo-deb / 各プラットフォームのパッケージツールを使用

開発の流れ（推奨）
1. フレームワークを決める（Tauri / Iced 等）
2. 小さなウィンドウ/メニューから機能を積み上げる
3. CIでビルドとクロスコンパイルを自動化
4. 自動テストと静的解析（clippy, rustfmt）

参考・ドキュメント
- 各フレームワークの公式ドキュメントを参照してセットアップとパッケージングを確認してください。

貢献
- Pull Request歓迎。Issueで相談してください。

ライセンス
- 適宜 LICENSE を追加してください。