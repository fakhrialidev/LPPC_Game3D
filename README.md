# LPPC_Game3D

Game 3D first-person shooter sederhana yang saya buat dengan Unity 6 (6000.6) untuk belajar C# dan dasar-dasar game development.

## Fitur

- Gerak karakter dengan W, A, S, D
- Putar pandangan dengan mouse
- Tembak peluru dengan klik kiri
- Peluru hilang otomatis setelah 5 detik
- Peluru yang mengenai objek bertag `Enemy` mematikan lampunya

## Script

| Script | Fungsi |
|---|---|
| `PlayerMovement.cs` | Gerak dan rotasi karakter |
| `PlayerShooting.cs` | Memunculkan dan menembakkan peluru |
| `Bullet.cs` | Umur peluru dan deteksi tabrakan |

## Cara menjalankan

1. Clone repository ini.
2. Buka folder project lewat Unity Hub memakai Unity 6 (6000.6).
3. Buka scene `SampleScene` di `Assets/Scenes`.
4. Di **Edit > Project Settings > Player > Active Input Handling**, pilih `Both` atau `Input Manager (Old)`.
5. Tekan Play.

## Kontrol

| Input | Aksi |
|---|---|
| W, A, S, D | Bergerak |
| Mouse | Melihat ke kiri dan kanan |
| Klik kiri | Menembak |

## Catatan

Project ini dibuat untuk latihan, jadi masih terus berkembang.
