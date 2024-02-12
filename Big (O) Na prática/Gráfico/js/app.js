const ctx = document.getElementById('graficoTempoExecucao').getContext('2d');

const graficoTempoExecucao = new Chart(ctx, {
  type: 'line',
  data: {
    labels: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10], // Tamanho da entrada
    datasets: [{
      label: 'O(1) - Tempo Constante',
      data: [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1], // Valores de tempo de execução para O(1)
      backgroundColor: 'rgba(255, 99, 132, 0.2)',
      borderColor: '#ffff01',
      borderWidth: 3
    }, {
      label: 'O(n) - Tempo Linear',
      data: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10], // Valores de tempo de execução para O(n)
      backgroundColor: 'rgba(54, 162, 235, 0.2)',
      borderColor: '#04e405',
      borderWidth: 3
    },
    {
      label: 'O(n^2) - Tempo Quadratico',
      data: [0*0, 1*1, 2*2, 3*3, 4*4, 5*5, 6*6, 7*7, 8*8, 9*9, 10*10], // Valores de tempo de execução para O(n^2)
      backgroundColor: 'rgba(54, 162, 235, 0.2)',
      borderColor: '#e71224',
      borderWidth: 3
    },
      {
        label: 'O(2^n) - Tempo Exponencial',
        data: [1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048], // Valores de tempo de execução para O(2^n)
        backgroundColor: 'rgba(255, 99, 132, 0.2)',
        borderColor: '#ff6384',
        borderWidth: 3
      }
    ],
  },
  options: {
    scales: {
      y: {
        beginAtZero: true
      }
    }
  }
});
