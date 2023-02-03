

Summary in this chapter

- Thread merupakan independent Execute path dalam sebuah program.
- Thread bekerja seperti sequential flow-control, yang memiliki starting point dan end point, yang mana setiap statement akan dieksekusi satu persatu
	dalam satu waktu sampai dengan statement code akhir.
- ketika method Main running, program akan otomatis membuat satu thread biasa (single thread, main thread, primary thread)
- Kelemahan dari single thread ini ialah saat task belum complete, maka task lain akan waiting, akibatnya status program akan halt

//MULTITHREAD
- programming pattern model yang mana program akan dibagi menjadi sub bagian yang akan dieksekusi secara parallel.
- Multithread ini dapat diimplemetansikan dengan membuat create tambahan dalam main thread.
- Context-Switching ialah penjadwalan yang ada didalam OSuntuk menentukan thread mana yang akan dieksekusi oleh processor.
- dalam multi thread, tiap thread akan memiliki stack yang berbeda, namun sharing data di heap yang sama