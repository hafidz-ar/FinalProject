-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 04 Jan 2025 pada 19.53
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `manajemen_properti`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `kembali`
--

CREATE TABLE `kembali` (
  `KembaliID` int(11) NOT NULL,
  `TransaksiID` int(11) DEFAULT NULL,
  `Tgl_kembali` date DEFAULT NULL,
  `Denda` decimal(10,2) DEFAULT NULL,
  `Keterangan` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `kembali`
--

INSERT INTO `kembali` (`KembaliID`, `TransaksiID`, `Tgl_kembali`, `Denda`, `Keterangan`) VALUES
(501, 401, '2026-01-01', 0.00, 'Selesai tanpa kendala'),
(502, 402, '2025-07-02', 0.00, 'Selesai tanpa kendala'),
(503, 403, '2027-01-03', 500000.00, 'Telat pengembalian 1 bulan'),
(504, 404, '2026-07-04', 0.00, 'Selesai tanpa kendala'),
(505, 405, '2026-01-05', 0.00, 'Selesai tanpa kendala');

-- --------------------------------------------------------

--
-- Struktur dari tabel `maintenance`
--

CREATE TABLE `maintenance` (
  `MaintenanceID` int(11) NOT NULL,
  `PropertiID` int(11) DEFAULT NULL,
  `NIP` int(11) DEFAULT NULL,
  `Tgl_Maintenance` date DEFAULT NULL,
  `Deskripsi` varchar(200) DEFAULT NULL,
  `Biaya` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `maintenance`
--

INSERT INTO `maintenance` (`MaintenanceID`, `PropertiID`, `NIP`, `Tgl_Maintenance`, `Deskripsi`, `Biaya`) VALUES
(601, 301, 101, '2025-01-15', 'Perbaikan AC', 150000.00),
(602, 302, 102, '2025-02-10', 'Perbaikan atap bocor', 300000.00),
(603, 303, 103, '2025-03-20', 'Penggantian lampu utama', 100000.00),
(604, 304, 104, '2025-04-15', 'Perbaikan pipa air', 200000.00),
(605, 305, 105, '2025-05-25', 'Penggantian jendela', 250000.00);

-- --------------------------------------------------------

--
-- Struktur dari tabel `penyewa`
--

CREATE TABLE `penyewa` (
  `PenyewaID` int(11) NOT NULL,
  `Nama` varchar(50) DEFAULT NULL,
  `Jenis_kelamin` char(1) DEFAULT NULL,
  `Alamat` varchar(100) DEFAULT NULL,
  `No_Hp` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `penyewa`
--

INSERT INTO `penyewa` (`PenyewaID`, `Nama`, `Jenis_kelamin`, `Alamat`, `No_Hp`) VALUES
(201, 'Rama Wijaya', 'L', 'Jl. Sakura No.5, Jakarta', '082134567890'),
(202, 'Dewi Kartika', 'P', 'Jl. Melati No.22, Bandung', '082198765432'),
(203, 'Siti Nurhaliza', 'P', 'Jl. Kenanga No.8, Surabaya', '082345678901'),
(204, 'Ahmad Fauzan', 'L', 'Jl. Mawar No.10, Yogyakarta', '082456789012'),
(205, 'Citra Dewi', 'P', 'Jl. Flamboyan No.12, Semarang', '082567890123');

-- --------------------------------------------------------

--
-- Struktur dari tabel `petugas`
--

CREATE TABLE `petugas` (
  `NIP` int(11) NOT NULL,
  `Nama` varchar(50) DEFAULT NULL,
  `Jenis_kelamin` char(1) DEFAULT NULL,
  `Alamat` varchar(100) DEFAULT NULL,
  `No_Hp` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `petugas`
--

INSERT INTO `petugas` (`NIP`, `Nama`, `Jenis_kelamin`, `Alamat`, `No_Hp`) VALUES
(101, 'Andi Setiawan', 'L', 'Jl. Merpati No.10, Jakarta', '081234567890'),
(102, 'Rina Amelia', 'P', 'Jl. Anggrek No.15, Bandung', '081298765432'),
(103, 'Budi Santoso', 'L', 'Jl. Cendana No.20, Surabaya', '081345678901'),
(104, 'Dian Pratama', 'L', 'Jl. Melati No.18, Yogyakarta', '081223344556'),
(105, 'Siti Aisyah', 'P', 'Jl. Kenanga No.9, Semarang', '081567890123');

-- --------------------------------------------------------

--
-- Struktur dari tabel `properti`
--

CREATE TABLE `properti` (
  `PropertiID` int(11) NOT NULL,
  `Jenis` varchar(30) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `Lokasi` varchar(100) DEFAULT NULL,
  `Tahun_bangun` int(11) DEFAULT NULL,
  `Harga_sewa` decimal(10,2) DEFAULT NULL,
  `Stok` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `properti`
--

INSERT INTO `properti` (`PropertiID`, `Jenis`, `Nama`, `Lokasi`, `Tahun_bangun`, `Harga_sewa`, `Stok`) VALUES
(301, 'Apartemen', 'Green Park Residence', 'Jl. Kemang Raya No.10, Jakarta', 2018, 5000000.00, 10),
(302, 'Rumah', 'Villa Indah', 'Jl. Setiabudi No.7, Bandung', 2015, 7000000.00, 5),
(303, 'Ruko', 'Sentra Niaga', 'Jl. Darmo No.25, Surabaya', 2020, 10000000.00, 3),
(304, 'Apartemen', 'Skyline Tower', 'Jl. Jendral Sudirman No.15, Jakarta', 2017, 6000000.00, 8),
(305, 'Rumah', 'Harmony Hills', 'Jl. Puncak No.5, Bandung', 2016, 7500000.00, 6);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `TransaksiID` int(11) NOT NULL,
  `PenyewaID` int(11) DEFAULT NULL,
  `NIP` int(11) DEFAULT NULL,
  `PropertiID` int(11) DEFAULT NULL,
  `Tgl_Sewa` date DEFAULT NULL,
  `Lama_sewa` int(11) DEFAULT NULL,
  `Keterangan` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`TransaksiID`, `PenyewaID`, `NIP`, `PropertiID`, `Tgl_Sewa`, `Lama_sewa`, `Keterangan`) VALUES
(401, 201, 101, 301, '2025-01-01', 12, 'Pembayaran lancar'),
(402, 202, 102, 302, '2025-01-02', 6, 'Pembayaran lancar'),
(403, 203, 103, 303, '2025-01-03', 24, 'Pembayaran tertunda 1 bulan'),
(404, 204, 104, 304, '2025-01-04', 18, 'Pembayaran lancar'),
(405, 205, 105, 305, '2025-01-05', 12, 'Pembayaran lancar');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `kembali`
--
ALTER TABLE `kembali`
  ADD PRIMARY KEY (`KembaliID`),
  ADD KEY `TransaksiID` (`TransaksiID`);

--
-- Indeks untuk tabel `maintenance`
--
ALTER TABLE `maintenance`
  ADD PRIMARY KEY (`MaintenanceID`),
  ADD KEY `PropertiID` (`PropertiID`),
  ADD KEY `NIP` (`NIP`);

--
-- Indeks untuk tabel `penyewa`
--
ALTER TABLE `penyewa`
  ADD PRIMARY KEY (`PenyewaID`);

--
-- Indeks untuk tabel `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`NIP`);

--
-- Indeks untuk tabel `properti`
--
ALTER TABLE `properti`
  ADD PRIMARY KEY (`PropertiID`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`TransaksiID`),
  ADD KEY `PenyewaID` (`PenyewaID`),
  ADD KEY `NIP` (`NIP`),
  ADD KEY `PropertiID` (`PropertiID`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `kembali`
--
ALTER TABLE `kembali`
  ADD CONSTRAINT `kembali_ibfk_1` FOREIGN KEY (`TransaksiID`) REFERENCES `transaksi` (`TransaksiID`);

--
-- Ketidakleluasaan untuk tabel `maintenance`
--
ALTER TABLE `maintenance`
  ADD CONSTRAINT `maintenance_ibfk_1` FOREIGN KEY (`PropertiID`) REFERENCES `properti` (`PropertiID`),
  ADD CONSTRAINT `maintenance_ibfk_2` FOREIGN KEY (`NIP`) REFERENCES `petugas` (`NIP`);

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`PenyewaID`) REFERENCES `penyewa` (`PenyewaID`),
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`NIP`) REFERENCES `petugas` (`NIP`),
  ADD CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`PropertiID`) REFERENCES `properti` (`PropertiID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
