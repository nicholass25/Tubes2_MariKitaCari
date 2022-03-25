# Tubes Stima 2 - MariKitaCari

## Pengaplikasian Algoritma BFS dan DFS dalam Implementasi Folder Crawling

Tugas Besar II IF2211 Strategi Algoritma

## Description
MariKitaCari merupakan aplikasi GUI sederhana yang memodelkan fitur dari file explorer pada sitem operasi (Folder Crawling). Program ini memanfaatkan algoritma Breadth First Search (BFS) dan Depth First Search (DFS) dalam penelusuran folder dalam direktori. Program ini dapat menampilkan visualisasi tree dari directory pengguna untuk menunjukkan proses pencarian.

## Requirement
- Sistem operasi: Windows 7 ke atas
- Pengguna dapat langsung menjalankan file executable pada directory ```bin\Debug\MariKitaCari.exe``` atau mem-build ulang program.

## Program Rebuilding
1. Buka Visual Studio
2. Buka menu Tools > NuGet Package Manager > Package Manager Console
3. Gunakan command
```Install-Package AutomaticGraphLayout -Version 1.1.11```
```Install-Package AutomaticGraphLayout.Drawing -Version 1.1.11```
```Install-Package AutomaticGraphLayout.WpfGraphControl -Version 1.1.11```
```Install-Package AutomaticGraphLayout.GraphViewerGDI -Version 1.1.11```
Untuk pengguna Windows 7 ke bawah,
```Install-Package Microsoft.WindowsAPICodePack-Shell -Version 1.1.0```
4. Build project
5. File .exe tersedia pada directory seperti di atas

## Usage

1. Execute ```MariKitaCari.exe```
2. Pilih starting directory melalui button "Choose Folder..."
3. Isi nama file yang ingin dicari dengan menuliskannya pada text box
4. Isi metode pencarian dengan memilih salah satu radio button
5. Pilih pencarian semua file dengan menge-check "Check All Occurence" (opsional)
6. Tekan button "Search"
7. Lihat visualisasi graf
8. Tekan link untuk membuka parent directory dari file

## Author
- 13520035 - Damianus Clairvoyance Diva Putra
- 13520121 - Nicholas Budiono
- 13520148 - Fikri Ihsan Fadhiilah
