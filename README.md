# SPSS_Parallel

SPSS Paralel merupakan aplikasi desktop yang berfungsi untuk menghitung fungsi - fungsi statistik sederhana, antara lain :

1. Modus
2. Median
3. Mean
4. Range
5. Regresi Linier
6. Standar Deviasi
7. Variansi

Bedanya aplikasi yang kami buat dengan aplikasi SPSS yang sudah ada yaitu kami menggunakan parallel computing untuk untuk menghitung fungsi - fungsi statistik yang ada. Untuk saat ini, fungsi variansi dan linier Regresi sederhana yang menggunakan parallel computing. Kedua fungsi tersebut cara memparalelkannya terletak pada SUM(jumlahan) dan perkalian. Kami menggunakan konsep SIMD(Single Instruction Multiple Data) untuk melakukan operasi jumlahan dan perkalian tersebut. Operasi komputasi dilakukan oleh GPU Nvidia, dimana kita menggunakan thread sebanyak setengah data yang dimasukkan dan setiap thread akan dimasukkan instruksi yang sama namun datanya berbeda-beda untuk tiap threadnya.

System Requirement untuk membuat aplikasi ini antara lain :

1. Software
   - Windows 10 x64 bit
   - Visual Studio 2013
   - [CUDA Toolkit v7.5](https://developer.nvidia.com/cuda-downloads)
2. Hardware
   - Nvidia Graphic Card
3. Package
   - Reogrid - .Net Spreadsheet Component v0.9.1.0
   - Json.Net v7.0.1
   - CUDAfy.Net v1.29

Catatan :

1. Aplikasi dibangun menggunakan bahasa pemrograman c#
2. Sebaiknya menggunakan Visual Studio 2013 atau dibawahnya karena untuk visual studio 2015 saat kami coba belum support dengan CUDA Toolkit.
3. Package Reogrid dan Json.Net akan secara otomatis terinstall jika kita mem-build ulang Source Code di atas.
4. Package CUDAfy.Net perlu mendapat perhatian khusus, karena versi CUDAfy.Net berpengaruh dengan versi CUDA Toolkit. Lihat link [Codeplex ini](https://cudafy.codeplex.com/) untuk melihat ketentuan. 
5. Jika terdapat pesan error saat mem-build, biasanya CUDAfy.Net perlu di update atau install ulang dengan cara:
   - Download di link [ini](https://cudafy.codeplex.com/). Diekstrak kemudian buka visual studio, pada jendela Solution Explorer Klik kanan References -> Add Reference -> Browse -> pindah ke folder Cudafy.Net diekstrak -> OK.
   - Pada jendela Solution Explorer Klik kanan References -> Manage NuGet Packages -> Uninstall Cudafy.Net kemudian install kembali.
6. Kemudian jika sudah berhasil dibuild dan menghitung variansi, tapi pada saat keluar jendela ResultForm hasil perhitungannya tidak muncul, kemungkinan source code tidak terkompilasi, cara menanganinya dengan cara menambahkan PATH VC pada folder Visual Studio ke Environment Variables. Contoh Path-nya : "C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\bin\amd64"

[Contoh File Hasil Kompilasi](http://1drv.ms/1UWYzNU)

Semoga Bermanfaat . . .
