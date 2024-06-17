public class Solution {

    public IList<IList<string>> SolveNQueens(int n) 
    {
        var board = new List<string>();
        var result = new List<IList<string>>();
        for(int i = 0; i<n; i++){
            board.Add("");
            for(int j = 0; j<n; j++){
                board[i] += ".";  
            }
        }
  
        backtracking(n, 0, board, result);
        
        return result;
    }

    public void backtracking(int n, int rowIndex, List<string> board, IList<IList<string>> result)
    {


        if(rowIndex >= n)
        {
            result.Add(board.ToList());
            return;
        }
        for(int colIndex = 0; colIndex < n; colIndex++)
        {
            if( isSafe(n, rowIndex, colIndex, board) )
            {
                StringBuilder sb = new StringBuilder(board[rowIndex]);
                sb[colIndex] = 'Q';
                board[rowIndex] = sb.ToString();
                Console.WriteLine(board[rowIndex]);

                backtracking(n, rowIndex + 1,  board, result);
                sb = new StringBuilder(board[rowIndex]);
                sb[colIndex] = '.';
                board[rowIndex] = sb.ToString();
                Console.WriteLine(board[rowIndex]);
            }
        }
        
    } 

    public bool isSafe(int n, int rowIndex, int columnIndex, List<string> board)
    {    
        //Vertical
        for(int i =  0; i < n; i++)
        {
            if( (i != rowIndex) && (board[i][columnIndex] == 'Q') )
            {
                return false;
            }
        }

        //downward right
        for(int i=rowIndex+1, j=columnIndex+1;    i<n && j<n;    i++, j++)
        {
            if(board[i][j] == 'Q' )
            {
                return false;
            }
        }

        //downward left
        for(int i=rowIndex+1,  j=columnIndex-1;    i<n && j>=0;    i++, j--)
        {
            if(board[i][j] == 'Q' )
            {
                return false;
            }
        }

        //upward left
        for(int i=rowIndex-1,  j=columnIndex-1;   ( i>=0 && j>=0);    i--, j--)
        {
            if(board[i][j] == 'Q' )
            {
                return false;
            }
        }


        //upward right
        for(int i=rowIndex-1,  j=columnIndex+1;    i>=0 && j<n;    i--, j++)
        {
            if(board[i][j] == 'Q' )
            {
                return false;
            }
        }

        
  

        return true;
    }
}

  