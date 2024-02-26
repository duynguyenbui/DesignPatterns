/**
 * Bài toán: Giả sử khi tạo một ứng dụng khai thác dữ liệu để
 * phân tích các tài liệu của công ty. Người dùng cung cấp các
 * tài liệu ứng dụng ở nhiều định dạng khác nhau (PDF, DOC, CSV) và ứng dụng trích
 * xuất dữ liệu có ý nghĩa từ các tài liệu này ở một định dạng thống nhất.
 */
using TemplateMethodPattern;

var pdfDataMiner = new PDFDataMiner();
pdfDataMiner.Mine("pdf path");

var csvDataMiner  = new CSVDataMiner();
csvDataMiner.Mine("csv path");