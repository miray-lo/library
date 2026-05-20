# libray
# 圖書管理程式 (Book Library Manager)

這是一個使用 C# Windows Forms 開發的圖書管理與借閱系統，為視窗程式設計的實作練習項目。本專案主要展示了 `ListView` 控制項的進階應用與事件綁定技巧。

## 🌟 核心功能

* **多重檢視模式切換**：透過右上方的下拉選單 (`ComboBox`)，可即時切換書籍清單的顯示模式（大圖示、詳細資料、小圖示、清單、大圖示加詳細資料）。
* **詳細資料展示**：在「詳細資料」檢視下，可完整呈現書籍的「書名」、「作者」與「類別」。
* **圖文整合介面**：利用 `ImageList` 綁定不同尺寸的影像，實現大圖示與小圖示的動態載入。
* **雙擊借閱機制**：設定 `Activation = TwoClick` 屬性，雙擊書籍圖示即可觸發 `ItemActivate` 事件並跳出借閱確認視窗。
* **防呆邏輯檢查**：系統在加入借書清單 (`ListBox`) 前，會自動比對書籍名稱，防止同一本書籍被重複借閱。

## 🛠️ 開發環境與技術

* **開發語言**：C#
* **介面框架**：Windows Forms
* **核心控制項**：`ListView`, `ImageList`, `ComboBox`, `ListBox`, `MessageBox`

## 🚀 執行與使用方式

1. 使用 Visual Studio 開啟本專案的 `.sln` 方案檔。
2. 按下 `F5` 或點擊「開始」編譯並執行程式。
3. 於右上方「檢視方式」下拉選單中切換不同的瀏覽版面。
4. 對著想借閱的書籍 **連按兩下左鍵**，點選「是」即可將書籍加入右下方的借書清單中。

---

## 👨‍💻 作者資訊
* **Author:** 羅健安 (Luo Jian-an)
* **Institution:** 元智大學 資訊工程學系 (YZU CS)
* <img width="805" height="562" alt="image" src="https://github.com/user-attachments/assets/ca62eaf4-d978-4a17-8cb3-ae3ec977fe04" />
