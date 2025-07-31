# Flappy-Bird
Game Flappy Bird là một bài tập nhỏ trên lớp của em.
Làm Game Flappy Bird đơn giản với Unity  
Mục tiêu: hoàn thành được game prototype Flappy Bird có gameplay cơ 
bản, dùng Rigidbody2D, Collider, Animation, Input và Score. 
THÔNG TIN BÀI LAB 
 Tên: Bài Lab 02 – Làm game Flappy Bird đơn giản 
 Thời lượng: 3 giờ 
 Mức độ: Cơ bản – dành cho học viên đã biết Scene, Sprite, Rigidbody2D 
 Phần mềm: Unity 6.1.1f1 hoặc mới hơn 
 Output mong muốn: 1 game Flappy Bird có thể chơi được, có tính điểm, 
va chạm và Game Over. 
1. Chuẩn bị (30 phút) 
Asset cần thiết 
 Background 
 Bird (1 sprite hoặc sheet animation 3 frames) 
 Pipe (ống trên và ống dưới) 
 Ground 
 Font số hoặc TMP Font 
 Âm thanh: jump, score, die (nếu có thời gian) 
Cài đặt ban đầu 
 Tạo Project mới: FlappyBirdLab 
 Import Asset và setup thư mục: Sprites/, Prefabs/, Scripts/, Audio/ 
 Tạo scene mới: GameScene 
2. Thiết lập GameObject (45 phút) 
Bird 
 Thêm Rigidbody2D: 
o Gravity Scale = 1.5 
o Freeze Rotation Z 
 Thêm CircleCollider2D 
 Add Script BirdController.cs: 
Pipe Spawner 
 Tạo Prefab PipePair gồm: 
o Ống trên và ống dưới (SpriteRenderer + BoxCollider2D) 
o Parent Object gắn MoveLeft.cs 
 Add script PipeSpawner.cs: 
Ground & Background 
 Ground: add BoxCollider2D để bắt va chạm 
 Background: dùng Sprite với Order in Layer = -1 
 Add script MoveLeft.cs cho Pipe & Ground: 
3. Gameplay và Score (45 phút) 
Va chạm và Game Over 
 Sử dụng OnCollisionEnter2D() để phát hiện va chạm 
Tính điểm khi Bird vượt Pipe 
 Gắn Trigger cho vùng giữa ống 
 Tạo tag ScoreZone, script ScoreTrigger.cs: 
GameManager.cs (singleton cơ bản) 
4. UI Hiển thị điểm (15 phút) 
 Tạo Canvas → Text (hoặc TextMeshPro) 
 Gắn script để cập nhật điểm số: 
5. Quy tắc Game Play 
 Bird luôn rơi tự do vì Gravity. 
 Chạm (Touch/Click/Space) để bird bay lên (velocity.y = jumpForce). 
 Nếu chạm ống hoặc chạm đất → Game Over. 
 Khi vượt qua cặp ống → +1 điểm. 
6. Yêu cầu Animation 
 Bird vỗ cánh liên tục (Animator). 
 Bird xoay nhẹ lên/xuống theo hướng bay. 
 Ground và Pipe di chuyển ngang → tạo hiệu ứng bay. 
7. Nộp bài & Đánh giá 
Yêu cầu hoàn thành: 
 Bird bay và rơi 
 Nhấn chuột để nhảy 
 Spawn ống liên tục 
 Va chạm với Pipe hoặc Ground => Game Over 
 Có tính điểm
