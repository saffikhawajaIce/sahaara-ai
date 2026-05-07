namespace SahaaraAI.Domain.Enums;

public enum CaseStatus
{
    Draft = 0,
    New = 1,
    AIClassified = 2,
    Matched = 3,
    OutreachDrafted = 4,
    PendingReview = 5,
    Sent = 6,
    WaitingForResponse = 7,
    FollowUpNeeded = 8,
    Accepted = 9,
    Rejected = 10,
    Referred = 11,
    Completed = 12,
    Closed = 13
}