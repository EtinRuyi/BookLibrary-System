﻿using BookLibrary.Model.DTOs;
using BookLibrary.Model.Entities.Shared;

namespace BookLibrary.Core.Services.Interface
{
    public interface IBookService
    {
        Task<BaseResponse<BookReturnDto>> AddBook(AddBookDTO addBookDTO);
        Task<BaseResponse<BookReturnDto>> UpdateBook(BookReturnDto book, Guid id);
        Task<BaseResponse<BookReturnDto>> GetBookById(Guid id);
        Task<BaseResponse<BookReturnDto>> DeleteBook(Guid id);
        Task<BaseResponse<IEnumerable<BookReturnDto>>> GetAllBook(int pagenumber, int pageSize);
        Task<BaseResponse<bool>> SearchBookByTitleAndAuthor(string title, string author);
    }
}
