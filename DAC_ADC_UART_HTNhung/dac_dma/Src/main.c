#include "main.h"
#include "math.h"
#define pi 3.141592

ADC_HandleTypeDef hadc1;
DMA_HandleTypeDef hdma_adc1;

DAC_HandleTypeDef hdac;
DMA_HandleTypeDef hdma_dac1;
DMA_HandleTypeDef hdma_dac2;

TIM_HandleTypeDef htim3;
TIM_HandleTypeDef htim6;
TIM_HandleTypeDef htim7;

UART_HandleTypeDef huart3;
DMA_HandleTypeDef hdma_usart3_rx;
DMA_HandleTypeDef hdma_usart3_tx;

void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_DMA_Init(void);
static void MX_ADC1_Init(void);
static void MX_DAC_Init(void);
static void MX_TIM6_Init(void);
static void MX_TIM7_Init(void);
static void MX_USART3_UART_Init(void);
static void MX_TIM3_Init(void);

uint16_t adc_value[4];
float A1,A1_pre,A1_out,A2,A2_pre,A2_out;
uint16_t f1,f1_pre,f1_out,f2,f2_pre,f2_out;
uint16_t Tim6_Period,Tim7_Period;
uint16_t Sin_step[20]={0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
uint16_t Triangle_step[18]={0,455,910,1365,1820,2275,2730,3185,3640,4095,3640,3185,2730,2275,1820,1365,910,455};
uint16_t Sin_wave[20],Triangle_wave[18];	
uint8_t Sin_Start='s',Sin_Mode='b',Triangle_Start='s',Triangle_Mode='b';

struct package {
	uint8_t header[4];
	uint8_t command[4];
	float A1_tr;
	float f1_tr;
	float A2_tr;
	float f2_tr;
}; //24 bytes uart dma transmit

struct receive {
	uint8_t header[4];
	uint8_t command[4];
	float A1;
	float f1;
	float A2;
	float f2;
}; //24 bytes uart dma receive

struct package Device_to_PC ;
struct receive PC_to_Device;
int n;
int main(void)
{

  HAL_Init();

  SystemClock_Config();

  MX_GPIO_Init();
  MX_DMA_Init();
  MX_ADC1_Init();
  MX_DAC_Init();
  MX_TIM6_Init();
  MX_TIM7_Init();
  MX_USART3_UART_Init();
  MX_TIM3_Init();
	
	HAL_ADC_Start_DMA(&hadc1,(uint32_t*)adc_value,4);
	HAL_DAC_Start_DMA(&hdac,DAC_CHANNEL_1,(uint32_t*)Sin_wave,20,DAC_ALIGN_12B_R);
	HAL_DAC_Start_DMA(&hdac,DAC_CHANNEL_2,(uint32_t*)Triangle_wave,18,DAC_ALIGN_12B_R);
	HAL_UART_Receive_DMA(&huart3, (uint8_t*)&PC_to_Device, 24);
  HAL_UART_Transmit_DMA(&huart3, (uint8_t*)&Device_to_PC, 24);
	HAL_TIM_Base_Start_IT(&htim3);
	HAL_TIM_Base_Start(&htim6);
	HAL_TIM_Base_Start(&htim7);
  while (1)
  {
		n=sizeof(PC_to_Device);
  }

}

void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart)
{
  
 UNUSED(huart);
	if (PC_to_Device.header[0] == 'd' && PC_to_Device.header[1] == 'k' && PC_to_Device.header[2] == 'n' && PC_to_Device.header[3] == 'h')//Header
	{
		///Bat song sin///
		if (PC_to_Device.command[0]=='r'){
			Sin_Start='r';
			Sin_Mode=PC_to_Device.command[1];

			
			///Mode gia tri Bien do va Tan so lay tu may tinh///
			if (Sin_Mode=='t'){
				A1_out=PC_to_Device.A1;
				f1_out=PC_to_Device.f1;
				Tim6_Period=1000000/(f1_out*20)-1;
				TIM6->ARR=(uint16_t)Tim6_Period;
				for(int i=0;i<=19;i++){
					Sin_wave[i]=(A1_out*sin(Sin_step[i]*pi/10)+A1_out)/3*4095;
				}
			}
		}
		///Tat song sin///
		else {
			Sin_Start='s';
			for(int i=0;i<=19;i++){
				Sin_wave[i]=0;
			}
			//HAL_TIM_Base_Stop(&htim6);
		}
		
		///Bat song Tam giac///
		if (PC_to_Device.command[2]=='r'){
			Triangle_Start='r';
			Triangle_Mode=PC_to_Device.command[3];
			
			///Mode gia tri Bien do va Tan so lay tu may tinh///
			if (Triangle_Mode=='t'){
				A2_out=PC_to_Device.A2;
				f2_out=PC_to_Device.f2;
				Tim7_Period=1000000/(f2_out*18)-1;
				TIM7->ARR=(uint16_t)Tim7_Period;
				for(int i=0;i<=17;i++){
					Triangle_wave[i]=(Triangle_step[i]*A2_out)/1.5;
				}
			}
		}
		///Tat song Tam giac///
		else {
			Triangle_Start='s';
			for(int i=0;i<=17;i++){
				Triangle_wave[i]=0;
			}
			//HAL_TIM_Base_Stop(&htim7);
		}

	}

}

//////////////Doc ADC va xuat DAC bang DMA/////////////
void HAL_ADC_ConvCpltCallback(ADC_HandleTypeDef* hadc){
	if (Sin_Start=='r'){
		if (Sin_Mode=='b'){
			A1=adc_value[0]/4095.0*1.5;
			A1_out=0.9*A1_pre+0.1*A1;
			A1_pre=A1_out;
			
			f1=adc_value[1]*999/4095+1;
			f1_out=0.9*f1_pre+0.1*f1;
			f1_pre=f1_out;
			
			Tim6_Period=1000000/(f1_out*20)-1;
			TIM6->ARR=(uint16_t)Tim6_Period;
			for(int i=0;i<=19;i++){
				Sin_wave[i]=(A1_out*sin(Sin_step[i]*pi/10)+A1_out)/3*4095;
			}
		}
	}
	
	if (Triangle_Start=='r'){
		if (Triangle_Mode=='b'){
			A2=adc_value[2]/4095.0*1.5;
			A2_out=0.9*A2_pre+0.1*A2;
			A2_pre=A2_out;
			
			f2=adc_value[3]*999/4095+1;
			f2_out=0.9*f2_pre+0.1*f2;
			f2_pre=f2_out;
			
			Tim7_Period=1000000/(f2_out*18)-1;
			TIM7->ARR=(uint16_t)Tim7_Period;
			for(int i=0;i<=17;i++){
				Triangle_wave[i]=(Triangle_step[i]*A2_out)/1.5;
			}
		}
	}

//		Device_to_PC.header[0] = 'd'; Device_to_PC.header[1] = 'k'; Device_to_PC.header[2] = 'n'; Device_to_PC.header[3] = 'h';
//		Device_to_PC.command[0]='o';Device_to_PC.command[1]='o';Device_to_PC.command[2]='o';Device_to_PC.command[3]='o';
//		Device_to_PC.A11=(float) A1_out;
//		Device_to_PC.f1=(float) f1_out;
//		Device_to_PC.A2=(float) A2_out;
//		Device_to_PC.f2=(float) f2_out;
//		USART3->CR3 |= (1<<7);

}

void HAL_UART_TxCpltCallback(UART_HandleTypeDef *huart)
{
  /* Prevent unused argument(s) compilation warning */
  UNUSED(huart);
  USART3->CR3 &= ~(1<<7);
}

void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim){
	//UNUSED(htim);
  if(htim->Instance == htim3.Instance){
		if (Sin_Start=='r' && Triangle_Start=='r'){
			Device_to_PC.header[0] = 'a'; Device_to_PC.header[1] = 'k'; Device_to_PC.header[2] = 'n'; Device_to_PC.header[3] = 'h';
			Device_to_PC.command[0]='o';Device_to_PC.command[1]='o';Device_to_PC.command[2]='o';Device_to_PC.command[3]='o';
			Device_to_PC.A1_tr=(float) A1_out;
			Device_to_PC.f1_tr=(float) f1_out;
			Device_to_PC.A2_tr=(float) A2_out;
			Device_to_PC.f2_tr=(float) f2_out;
			USART3->CR3 |= (1<<7);
		}
	}
}

void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Configure the main internal regulator output voltage 
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);
  /** Initializes the CPU, AHB and APB busses clocks 
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLM = 8;
  RCC_OscInitStruct.PLL.PLLN = 336;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
  RCC_OscInitStruct.PLL.PLLQ = 7;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB busses clocks 
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV4;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV4;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_5) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief ADC1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_ADC1_Init(void)
{

  /* USER CODE BEGIN ADC1_Init 0 */

  /* USER CODE END ADC1_Init 0 */

  ADC_ChannelConfTypeDef sConfig = {0};

  /* USER CODE BEGIN ADC1_Init 1 */

  /* USER CODE END ADC1_Init 1 */
  /** Configure the global features of the ADC (Clock, Resolution, Data Alignment and number of conversion) 
  */
  hadc1.Instance = ADC1;
  hadc1.Init.ClockPrescaler = ADC_CLOCK_SYNC_PCLK_DIV2;
  hadc1.Init.Resolution = ADC_RESOLUTION_12B;
  hadc1.Init.ScanConvMode = ENABLE;
  hadc1.Init.ContinuousConvMode = ENABLE;
  hadc1.Init.DiscontinuousConvMode = DISABLE;
  hadc1.Init.ExternalTrigConvEdge = ADC_EXTERNALTRIGCONVEDGE_NONE;
  hadc1.Init.ExternalTrigConv = ADC_SOFTWARE_START;
  hadc1.Init.DataAlign = ADC_DATAALIGN_RIGHT;
  hadc1.Init.NbrOfConversion = 4;
  hadc1.Init.DMAContinuousRequests = ENABLE;
  hadc1.Init.EOCSelection = ADC_EOC_SINGLE_CONV;
  if (HAL_ADC_Init(&hadc1) != HAL_OK)
  {
    Error_Handler();
  }
  /** Configure for the selected ADC regular channel its corresponding rank in the sequencer and its sample time. 
  */
  sConfig.Channel = ADC_CHANNEL_0;
  sConfig.Rank = 1;
  sConfig.SamplingTime = ADC_SAMPLETIME_480CYCLES;
  if (HAL_ADC_ConfigChannel(&hadc1, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /** Configure for the selected ADC regular channel its corresponding rank in the sequencer and its sample time. 
  */
  sConfig.Channel = ADC_CHANNEL_1;
  sConfig.Rank = 2;
  if (HAL_ADC_ConfigChannel(&hadc1, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /** Configure for the selected ADC regular channel its corresponding rank in the sequencer and its sample time. 
  */
  sConfig.Channel = ADC_CHANNEL_2;
  sConfig.Rank = 3;
  if (HAL_ADC_ConfigChannel(&hadc1, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /** Configure for the selected ADC regular channel its corresponding rank in the sequencer and its sample time. 
  */
  sConfig.Channel = ADC_CHANNEL_3;
  sConfig.Rank = 4;
  if (HAL_ADC_ConfigChannel(&hadc1, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN ADC1_Init 2 */

  /* USER CODE END ADC1_Init 2 */

}

/**
  * @brief DAC Initialization Function
  * @param None
  * @retval None
  */
static void MX_DAC_Init(void)
{

  /* USER CODE BEGIN DAC_Init 0 */

  /* USER CODE END DAC_Init 0 */

  DAC_ChannelConfTypeDef sConfig = {0};

  /* USER CODE BEGIN DAC_Init 1 */

  /* USER CODE END DAC_Init 1 */
  /** DAC Initialization 
  */
  hdac.Instance = DAC;
  if (HAL_DAC_Init(&hdac) != HAL_OK)
  {
    Error_Handler();
  }
  /** DAC channel OUT1 config 
  */
  sConfig.DAC_Trigger = DAC_TRIGGER_T6_TRGO;
  sConfig.DAC_OutputBuffer = DAC_OUTPUTBUFFER_ENABLE;
  if (HAL_DAC_ConfigChannel(&hdac, &sConfig, DAC_CHANNEL_1) != HAL_OK)
  {
    Error_Handler();
  }
  /** DAC channel OUT2 config 
  */
  sConfig.DAC_Trigger = DAC_TRIGGER_T7_TRGO;
  if (HAL_DAC_ConfigChannel(&hdac, &sConfig, DAC_CHANNEL_2) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN DAC_Init 2 */

  /* USER CODE END DAC_Init 2 */

}

/**
  * @brief TIM3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM3_Init(void)
{

  /* USER CODE BEGIN TIM3_Init 0 */

  /* USER CODE END TIM3_Init 0 */

  TIM_ClockConfigTypeDef sClockSourceConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM3_Init 1 */

  /* USER CODE END TIM3_Init 1 */
  htim3.Instance = TIM3;
  htim3.Init.Prescaler = 8399;
  htim3.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim3.Init.Period = 1999;
  htim3.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim3.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim3) != HAL_OK)
  {
    Error_Handler();
  }
  sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
  if (HAL_TIM_ConfigClockSource(&htim3, &sClockSourceConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim3, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM3_Init 2 */

  /* USER CODE END TIM3_Init 2 */

}

/**
  * @brief TIM6 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM6_Init(void)
{

  /* USER CODE BEGIN TIM6_Init 0 */

  /* USER CODE END TIM6_Init 0 */

  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM6_Init 1 */

  /* USER CODE END TIM6_Init 1 */
  htim6.Instance = TIM6;
  htim6.Init.Prescaler = 83;
  htim6.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim6.Init.Period = 9;
  htim6.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim6) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_UPDATE;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim6, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM6_Init 2 */

  /* USER CODE END TIM6_Init 2 */

}

/**
  * @brief TIM7 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM7_Init(void)
{

  /* USER CODE BEGIN TIM7_Init 0 */

  /* USER CODE END TIM7_Init 0 */

  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM7_Init 1 */

  /* USER CODE END TIM7_Init 1 */
  htim7.Instance = TIM7;
  htim7.Init.Prescaler = 83;
  htim7.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim7.Init.Period = 9;
  htim7.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim7) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_UPDATE;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim7, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM7_Init 2 */

  /* USER CODE END TIM7_Init 2 */

}

/**
  * @brief USART3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART3_UART_Init(void)
{

  /* USER CODE BEGIN USART3_Init 0 */

  /* USER CODE END USART3_Init 0 */

  /* USER CODE BEGIN USART3_Init 1 */

  /* USER CODE END USART3_Init 1 */
  huart3.Instance = USART3;
  huart3.Init.BaudRate = 115200;
  huart3.Init.WordLength = UART_WORDLENGTH_8B;
  huart3.Init.StopBits = UART_STOPBITS_1;
  huart3.Init.Parity = UART_PARITY_NONE;
  huart3.Init.Mode = UART_MODE_TX_RX;
  huart3.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart3.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart3) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART3_Init 2 */

  /* USER CODE END USART3_Init 2 */

}

/** 
  * Enable DMA controller clock
  */
static void MX_DMA_Init(void) 
{

  /* DMA controller clock enable */
  __HAL_RCC_DMA2_CLK_ENABLE();
  __HAL_RCC_DMA1_CLK_ENABLE();

  /* DMA interrupt init */
  /* DMA1_Stream1_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Stream1_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Stream1_IRQn);
  /* DMA1_Stream3_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Stream3_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Stream3_IRQn);
  /* DMA1_Stream5_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Stream5_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Stream5_IRQn);
  /* DMA1_Stream6_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Stream6_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Stream6_IRQn);
  /* DMA2_Stream0_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA2_Stream0_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA2_Stream0_IRQn);

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOH_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */

  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{ 
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     tex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
