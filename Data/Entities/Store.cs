namespace Data.Entities;

/// <summary>
/// 판매점
/// </summary>
public class Store
{
    /// <summary>
    /// 고유 점포 번호
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// 점포명
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// 사업자명
    /// </summary>
    public string BossName { get; set; }
    
    /// <summary>
    /// 사업자번호
    /// </summary>
    public string BusinessNumber { get; set; }
    
    /// <summary>
    /// 연락처
    /// </summary>
    public string ContactNumber { get; set; }
    
    /// <summary>
    /// 주소
    /// </summary>
    public string Address { get; set; }
    
    /// <summary>
    /// 상세주소
    /// </summary>
    public string DetailAddress { get; set; }
    
    /// <summary>
    /// 우편번호
    /// </summary>
    public string PostCode { get; set; }
}